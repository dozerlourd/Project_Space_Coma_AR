using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    Vector3 tempVec = Vector3.zero;
    [SerializeField] float rotSpeed;

    void Update()
    {
        
        float h = ControllerSystem.Instance.horizontal_InputDirection.x == 0 ? 0 : ControllerSystem.Instance.horizontal_InputDirection.x > 0 ? 1 : -1;
        float v = ControllerSystem.Instance.vertical_InputDirection.y == 0 ? 0 : ControllerSystem.Instance.vertical_InputDirection.y > 0 ? 1 : -1;
        //tempVec = new Vector3(-v, h, 0);

        tempVec = new Vector3(-v, h, 0);

        transform.Rotate(tempVec * rotSpeed * Time.deltaTime);
    }
}
