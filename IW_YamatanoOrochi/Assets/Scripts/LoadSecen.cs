using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSecen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator LoadSceneAndWait()
    {
        float start = Time.realtimeSinceStartup;
        AsyncOperation ope = SceneManager.LoadSceneAsync("Battle");
        ope.allowSceneActivation = false;

        while (Time.realtimeSinceStartup - start < 1)
        {
            yield return null;
        }
        ope.allowSceneActivation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            StartCoroutine(LoadSceneAndWait());
        }
    }

    
}
