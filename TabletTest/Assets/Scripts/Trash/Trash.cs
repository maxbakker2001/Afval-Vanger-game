using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class Trash : MonoBehaviour
{
    private Action<Trash> _KillAction;
    public UnityEvent Trashgevangen;

    public void Init(Action<Trash> killAction)
    {
        _KillAction = killAction;
    }

    private void OnCollisionEnter(Collision col)
    {
        Trashgevangen.Invoke();
        if (col.transform.CompareTag("Netjes")) _KillAction(this);
    }
}