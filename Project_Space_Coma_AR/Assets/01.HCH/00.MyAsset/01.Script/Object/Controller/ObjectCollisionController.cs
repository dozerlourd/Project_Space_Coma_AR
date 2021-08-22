using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionController : MonoBehaviour
{
    protected void OnCollisionEnter(Collision col)
    {
        PlayerCheck(col);

        CollisionActivation(col);

        PopThisObject();
    }

    protected void PlayerCheck(Collision col)
    {
        if (col.gameObject.tag != "T_Player") return;
    }

    protected void PopThisObject()
    {
        JHS.PoolManager.Instance.PopObject(gameObject);
    }

    protected virtual void CollisionActivation(Collision col) { }
}
