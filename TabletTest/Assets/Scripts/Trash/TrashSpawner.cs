using System.Collections;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField] private Trash [] trashPrefab;

    [SerializeField] private SpawnPoint[] spawnPoints;


    [SerializeField] private float spawnFrequency = 1.7f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, spawnFrequency);
    }

    IEnumerator SpawnFreq()
    {
        yield return new WaitForSeconds(20f);
    }

    private void Spawn() // spawn one random trash
    {
        var i = Random.Range(0, trashPrefab.Length);
        var g = Instantiate(trashPrefab[i], GetSpawnLocation(), Random.rotation);
        g.transform.parent = GameObject.Find("TrashPile").transform;
    }

    private Vector3 GetSpawnLocation()
    {
        var i = Random.Range(0, spawnPoints.Length);
        return spawnPoints[i].returnPosition();
    }
}