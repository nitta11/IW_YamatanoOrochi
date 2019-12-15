using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackChance : MonoBehaviour
{

    GameObject yamata1;
    Animator animator1;

    GameObject yamata2;
    Animator animator2;

    GameObject yamata3;
    Animator animator3;

    GameObject yamata4;
    Animator animator4;

    GameObject yamata5;
    Animator animator5;

    GameObject yamata6;
    Animator animator6;

    GameObject yamata7;
    Animator animator7;

    GameObject yamata8;
    Animator animator8;

    GameObject win;

    float AttackTime;

    float ClearTime;

    private AudioSource audioSource;

    private Color Damaged= Color.red;

    private Color yamaC1;
    private Color yamaC2;
    private Color yamaC3;
    private Color yamaC4;
    private Color yamaC5;
    private Color yamaC6;
    private Color yamaC7;
    private Color yamaC8;

    int AttackCount;
    // CharacterController characterController;

    float a = 0;


    void OnTriggerEnter(Collider other)
    {
        if (other.name == "head")
        {
            audioSource.Play();
            AttackCount++;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        yamata1 = GameObject.Find("yamata_OculusGo_001");
      //  characterController = yamata.GetComponent<CharacterController>();
        animator1 = yamata1.GetComponent<Animator>();

        yamata2 = GameObject.Find("yamata_OculusGo_002");
        animator2 = yamata2.GetComponent<Animator>();

        yamata3 = GameObject.Find("yamata_OculusGo_003");
        animator3 = yamata3.GetComponent<Animator>();

        yamata4 = GameObject.Find("yamata_OculusGo_004");
        animator4 = yamata4.GetComponent<Animator>();

        yamata5 = GameObject.Find("yamata_OculusGo_005");
        animator5 = yamata5.GetComponent<Animator>();

        yamata6 = GameObject.Find("yamata_OculusGo_006");
        animator6 = yamata6.GetComponent<Animator>();

        yamata7 = GameObject.Find("yamata_OculusGo_007");
        animator7 = yamata7.GetComponent<Animator>();

        yamata8 = GameObject.Find("yamata_OculusGo_008");
        animator8 = yamata8.GetComponent<Animator>();

        AttackTime = 0f;

        win = GameObject.Find("Win");
    }

    // Update is called once per frame
    void Update()
    {
        AttackTime += Time.deltaTime;

        //今のコードだと最初の登場で３秒立つのでトリガーが２個同時に入ります。
        if(AttackTime>= 3f)
        {
            int random = Random.Range(0, 8);
            AttackTime = 0f;

            switch (random)
            {
                case 0:
                    animator1.SetTrigger("AttackT");
                    break;

                case 1:
                    animator2.SetTrigger("AttackT");
                    break;

                case 2:
                    animator3.SetTrigger("AttackT");
                    break;

                case 3:
                    animator4.SetTrigger("AttackT");
                    break;

                case 4:
                    animator5.SetTrigger("AttackT");
                    break;

                case 5:
                    animator6.SetTrigger("AttackT");
                    break;

                case 6:
                    animator7.SetTrigger("AttackT");
                    break;

                case 8:
                    animator8.SetTrigger("AttackT");
                    break;

                default:
                    break;
            }
        }


        if (AttackCount >= 6)
        {
            animator1.SetBool("Dead", true);
            animator2.SetBool("Dead", true);
            animator3.SetBool("Dead", true);
            animator4.SetBool("Dead", true);
            animator5.SetBool("Dead", true);
            animator6.SetBool("Dead", true);
            animator7.SetBool("Dead", true);
            animator8.SetBool("Dead", true);

            win.gameObject.transform.position = new Vector3(404.72f, 19f, 214.01f);

        /*   if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                SceneManager.LoadScene("TitleScene");
            }
        */

            ClearTime += Time.deltaTime;
            if (ClearTime >= 20f)
            {
                SceneManager.LoadScene("TitleScene");
            }


        }
        
     /*   if (a == 0) {
            Debug.Log("attack");
            animator1.SetTrigger("AttackT");
            a++;
        }
    */

    //    Debug.Log(a);
    }
}
