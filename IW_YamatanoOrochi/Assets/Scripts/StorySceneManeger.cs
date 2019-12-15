using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StorySceneManeger : MonoBehaviour
{
    public float alfa, red, green, blue;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        alfa = GetComponent<Image>().color.a;
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (alfa > 0)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa -= speed;
        }
        */
    }
}
