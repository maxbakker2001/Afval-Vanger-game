using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class TrashSpawner : MonoBehaviour
{
    private ObjectPool<Trash> _pool;

    [Header("References")] [SerializeField]
    private Trash trashPrefab;
    
    [Header("Variables")] 
    [SerializeField] private int trashCount = 10;
    [SerializeField] private int maxTrash = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        _pool = new ObjectPool<Trash>(() =>
        {
            return Instantiate(trashPrefab);
        }, trash =>
        {
            trash.gameObject.SetActive(true);
        }, trash =>
        {
            trash.gameObject.SetActive(false);
        }, trash =>
        {
            Destroy(trash.gameObject);
        },false,trashCount,maxTrash);
    }

    private void Spawn()
    {
        for (var i = 0; i < trashCount; i++)
        {
            _pool.Get();
        }
    }

    private void KillTrash(Trash trash)
    {
        _pool.Release(trash);
    }
}
