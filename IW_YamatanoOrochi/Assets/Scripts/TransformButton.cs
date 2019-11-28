using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformButton : MonoBehaviour
{
    public void ChosenButton()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.z += (-550f - pos.z) * 0.5f;

        myTransform.position = pos;
    }

    public void ExitChosenButton()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.z = -450f;

        myTransform.position = pos;
    }

    private void OnMouseOver()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.z += (-550f - pos.z) * 0.5f;

        myTransform.position = pos;
    }

    private void OnMouseExit()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.z = -450f;

        myTransform.position = pos;
    }
    /*
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    */
}
