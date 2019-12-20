using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCol : MonoBehaviour
{
    [SerializeField] Color[] Colors;
    Renderer Renderer;
    int CurrentColorIdx;


    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        ChangeMaterialColor();
    }

    // Start is called before the first frame update
    void Start()
    {
        //何度も呼ぶAPIはキャッシュしておくといいです。
        Renderer = GetComponent<Renderer>();
        //始めのカラーを表示
        ChangeMaterialColor();　
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void ChangeMaterialColor()
    {
        Renderer.material.color = Colors[CurrentColorIdx];
        CurrentColorIdx++;
        if (CurrentColorIdx >= Colors.Length) CurrentColorIdx = 0;
    }
}

