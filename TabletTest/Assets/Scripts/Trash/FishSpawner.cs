using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Fishprefab;

    [SerializeField] SpawnPoint[] spawnpoints;

    [SerializeField] float spawnFreq;

    void SpawnFish()
    {
        var i = Random.Range(0, Fishprefab.Length);
        var g = Instantiate(Fishprefab[i], GetTransform(), Fishprefab[i].transform.rotation);
        g.transform.parent = GameObject.Find("FishPile").transform;
    }

    private void Start()
    { 
        InvokeRepeating(nameof(SpawnFish), 0.1f, spawnFreq);
    }

    Vector3 GetTransform()
    {
        var i = Random.Range(0, spawnpoints.Length);
        return spawnpoints[i].returnPosition();
    }
}
