using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class TrashCollector : MonoBehaviour
{
    private Action<TrashCollector> _KillAction;

    public void Init(Action<TrashCollector> killAction)
    {
        _KillAction = killAction;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Netjes")) _KillAction(this);
        {
        }
    }
}