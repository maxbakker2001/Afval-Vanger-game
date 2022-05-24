using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class TrashSpawner : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Trash trashPrefab;

    [SerializeField] private SpawnPoint[] spawnPoints;


    [SerializeField] private int spawnFrequency = 5;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0.1f, spawnFrequency);
    }



    private void Spawn()
    {
        Instantiate(trashPrefab, GetSpawnLocation(), transform.rotation);
    }

    private Vector3 GetSpawnLocation()
    {
        var i = Random.Range(0, spawnPoints.Length);
        return spawnPoints[i].returnPosition();
    }


}