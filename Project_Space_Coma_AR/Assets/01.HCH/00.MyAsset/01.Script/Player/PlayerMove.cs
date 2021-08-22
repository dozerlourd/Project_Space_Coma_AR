using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
