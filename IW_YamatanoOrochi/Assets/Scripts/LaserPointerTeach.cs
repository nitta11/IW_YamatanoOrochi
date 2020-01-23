using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserPointerTeach : MonoBehaviour
{
    [SerializeField]
    private Transform _RightHandAnchor;

    [SerializeField]
    private Transform _LeftHandAnchor;

    [SerializeField]
    private Transform _CenterEyeAnchor;

    [SerializeField]
    private float _MaxDistance = 100.0f;

    [SerializeField]
    private LineRenderer _LaserPointerRenderer;

    GameObject StartButton;
    GameObject FinishButton;
    GameObject FadeOutPanel;

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

    void Start()
    {
        StartButton = GameObject.Find("StartButton");
        FinishButton = GameObject.Find("FinishButton");
        FadeOutPanel = GameObject.Find("FadeOut"); 
    }

    void Update()
    {
        var pointer = Pointer;
        if (pointer == null || _LaserPointerRenderer == null)
        {
            return;
        }
        // コントローラー位置からRayを飛ばす
        Ray pointerRay = new Ray(pointer.position, pointer.forward);

        // レーザーの起点
        _LaserPointerRenderer.SetPosition(0, pointerRay.origin);

        RaycastHit hitInfo;
        if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance))
        {
            // Rayがヒットしたらそこまで
            _LaserPointerRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            // Rayがヒットしなかったら向いている方向にMaxDistance伸ばす
            _LaserPointerRenderer.SetPosition(1, pointerRay.origin + pointerRay.direction * _MaxDistance);
        }

        if (Physics.Raycast(pointerRay, out hitInfo))
        {
            //Rayが当たったオブジェクトのtagがPlayerだったら
            if (hitInfo.collider.name == "StartButton")
            {
                StartButton.GetComponent<TransformButton>().ChosenButton();

                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    FadeOutPanel.GetComponent<TransformScene>().StartFadeOut();
                }

            }

                
        }
    }
}
