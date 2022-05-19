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
        //  按ESC退出全屏
        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.fullScreen = false;  //退出全屏         

        }

        //按A全屏
        if (Input.GetKey(KeyCode.A))
        {
            Screen.SetResolution(1600, 900, true);

            Screen.fullScreen = true;  //设置成全屏,
        }
    }
}


