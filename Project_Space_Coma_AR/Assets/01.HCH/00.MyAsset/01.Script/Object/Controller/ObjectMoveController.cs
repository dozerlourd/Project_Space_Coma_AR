using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectMoveController : MonoBehaviour
{
    [SerializeField] protected float moveSpeed, rotSpeed;

    protected Vector3 moveVec, rotVec;

    protected abstract void ObjectMove();

    protected abstract void ObjectRotate();
}
