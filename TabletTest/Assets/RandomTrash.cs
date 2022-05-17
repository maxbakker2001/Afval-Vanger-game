using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrash : MonoBehaviour
{
    public GameObject[] trash;

    private void Start()
    {
        PickRandomTrash();
    }

    private void PickRandomTrash()
    {
        trash[Random.Range(0, trash.Length)].SetActive(true);
    }
}