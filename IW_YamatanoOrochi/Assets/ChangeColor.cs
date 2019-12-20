using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color Original;

    // Start is called before the first frame update
    void Start()
    {
        Original = gameObject.GetComponent<Renderer>().material.color;

    }

    public void Damaged()
    {
        StartCoroutine("DamagedColor");
    }

    IEnumerator DamagedColor()
    {
        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(2);

        GetComponent<Renderer>().material.color = Original;

    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
