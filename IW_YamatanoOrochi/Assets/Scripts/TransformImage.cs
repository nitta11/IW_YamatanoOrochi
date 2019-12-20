using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TransformImage : MonoBehaviour
{
	public float alfa,red,green,blue;
    public float speed = 0.01f;


    public bool FadeOutTime;

    void Start()
    {
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
	}

    public void StartFadeOut()
	{
        SceneManager.LoadScene("Story");
    }


    void Update()
    {
       /* if (FadeOutTime == true && alfa<1)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;

        }
        if (alfa >= 1)
        {
            SceneManager.LoadScene("Story");
        }
        */
        
    }
}
