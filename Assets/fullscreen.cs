using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class fullscreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //  ��ESC�˳�ȫ��
        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.fullScreen = false;  //�˳�ȫ��         

        }

        //��Aȫ��
        if (Input.GetKey(KeyCode.A))
        {
            Screen.SetResolution(1600, 900, true);

            Screen.fullScreen = true;  //���ó�ȫ��,
        }
    }
}


