using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlastic : MonoBehaviour
{
    [SerializeField] private GameObject[] Trash;

    private void Start()
    {
        Trash = GameObject.FindGameObjectsWithTag("trash");
    }

    public void DestroyRandomTrash()
    {
        Destroy(Trash[Random.Range(0, Trash.Length)]);
    }
}