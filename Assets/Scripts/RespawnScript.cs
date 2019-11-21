using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnScript : MonoBehaviour
{
    private int frame = 0;
    private float time = 0.0f;

    //対象のオブジェクト
    public GameObject desObj;
    private bool isRespon = false;
    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 pos3;

    // Start is called before the first frame update
    void Start()
    {
/*        Transform myTransform = this.transform;*/
        pos1 = GameObject.Find("Area1").transform.position;
        pos2 = GameObject.Find("Area2").transform.position;
        pos3 = GameObject.Find("Area3").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRespon)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = pos1;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = pos2;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = pos3;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                time = 0.0f;
                isRespon = false;
                this.desObj.SetActive(true);
                this.desObj.transform.position = CameraScript.pos;
            }

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Man")) { 

            this.desObj.SetActive(false);
            isRespon = true;
        }
    }
}
