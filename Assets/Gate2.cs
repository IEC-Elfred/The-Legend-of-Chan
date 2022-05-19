using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject gate = GameObject.Find("Cauldron01");
        float dis = Vector3.Distance(this.transform.position, gate.transform.position);
        if(dis<1){
            SceneManager.LoadScene("Scene_Demo");
        }
    }
}