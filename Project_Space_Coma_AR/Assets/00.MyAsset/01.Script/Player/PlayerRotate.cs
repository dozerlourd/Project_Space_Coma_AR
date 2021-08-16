using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    void Update()
    {
        float h = ControllerSystem.Instance.horizontal_InputDirection.x;
        float v = ControllerSystem.Instance.vertical_InputDirection.y;

        transform.eulerAngles += new Vector3(-v * Time.deltaTime, h * Time.deltaTime, transform.rotation.z);
    }
}
