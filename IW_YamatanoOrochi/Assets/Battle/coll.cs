using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("coll");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "と衝突しました!!!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
