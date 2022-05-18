using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class TrashSpawner : MonoBehaviour
{
    private ObjectPool<Trash> _pool;

    [Header("References")] 
    [SerializeField] private Trash trashPrefab;
    [SerializeField] private SpawnPoint[] spawnPoints;
    
    [Header("Variables")] 
    [SerializeField] private int trashCount = 10;
    [SerializeField] private int maxTrash = 20;
    [SerializeField] private int spawnFrequency = 5;

    // Start is called before the first frame update
    void Start()
    {
        _pool = new ObjectPool<Trash>(() => Instantiate(trashPrefab, GetSpawnLocation(), Quaternion.identity), trash =>
        {
            trash.gameObject.SetActive(true);
        }, trash =>
        {
            trash.gameObject.SetActive(false);
        }, trash =>
        {
            Destroy(trash.gameObject);
        },false,trashCount,maxTrash);
        
        InvokeRepeating(nameof(Spawn), 0.1f, spawnFrequency);
    }

    private void Update()
    {
        print(_pool.CountActive);
    }

    private void Spawn()
    {
        _pool.Get();
    }

    private Vector3 GetSpawnLocation()
    {
        var i = Random.Range(0, spawnPoints.Length);
        return spawnPoints[i].returnPosition();
    }

    private void KillTrash(Trash trash)
    {
        _pool.Release(trash);
    }
}
