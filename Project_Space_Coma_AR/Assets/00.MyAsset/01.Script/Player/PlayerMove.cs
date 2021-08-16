using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    public float moveSpeed = 0.2f;
    float hAxis;
    float vAxis;
    bool wDown;

    Vector3 move;
    Vector3 bossMove = Vector3.zero;


    Quaternion rotate;
    Vector3 moveVec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.rotation = Quaternion.Slerp(transform.rotation, rotate, 25.0f * Time.deltaTime);
        rotate = Quaternion.LookRotation(new Vector3(move.x, 0, move.z));


        // float h = Input.GetAxis("Horizontal");
        //  float v = Input.GetAxis("Vertical");
        //wDown = Input.GetButton("Walk");


        moveVec = new Vector3(0, 0, 10).normalized;
        transform.position += moveVec * moveSpeed * Time.deltaTime;


        if (Input.GetKey(KeyCode.W))
        { 
                this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))                                                                                                                                                                                                                                                    
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
