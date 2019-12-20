using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSword : MonoBehaviour
{
    [SerializeField]
    private Transform _RightHandAnchor;

    [SerializeField]
    private Transform _LeftHandAnchor;

    [SerializeField]
    private Transform _CenterEyeAnchor;

    private Transform Pointer
    {
        get
        {
            // 現在アクティブなコントローラーを取得
            var controller = OVRInput.GetActiveController();
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                return _RightHandAnchor;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                return _LeftHandAnchor;
            }
            // どちらも取れなければ目の間からビームが出る
            return _CenterEyeAnchor;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pointer = Pointer;

        this.gameObject.transform.position = pointer.position;

        var controller = OVRInput.GetActiveController();
        if (controller != OVRInput.Controller.None)
        {//コントローラが存在すれば
         //取得したコントローラーから傾き（回転）角度の所得
            var rotation = OVRInput.GetLocalControllerRotation(controller);
            //取得した角度をバラして飛行機の操縦用に調整（assetの調整なので、ここは自分のプロジェクトにあった調整をする）
            float pitch = rotation.x;//ピッチ
            float roll = rotation.z;//ロール
            float yaw = rotation.y;//ヨー

            rotation.x -= 0.16f;

            this.gameObject.transform.rotation = rotation;
        }
    }
}
