using UnityEngine;
using Random = UnityEngine.Random;

public class TrashSpawner : MonoBehaviour
{


    [SerializeField] private Trash trashPrefab;

    [SerializeField] private SpawnPoint[] spawnPoints;


    [SerializeField] private float spawnFrequency = 1.7f;

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