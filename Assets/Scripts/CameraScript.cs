using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    public static Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.Rotate(-0.1f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(0.1f, 0.0f, 0.0f);
        }
        // 前に移動
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0.0f, 0.1f, 0.0f);
        }
        // 後ろに移動
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0.0f, -0.1f, 0.0f);
        }
        pos = this.transform.position;

    }

}
