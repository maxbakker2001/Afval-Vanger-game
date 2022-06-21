using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("trash"))
        {
            Destroy(gameObject);
        }
    }
}
