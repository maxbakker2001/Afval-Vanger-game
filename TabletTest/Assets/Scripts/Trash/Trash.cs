using UnityEngine;
using TMPro;

public class Trash : MonoBehaviour
{
    [SerializeField]
    private float grafity;
    public  bool grav;
    

    private void Awake()
    {
        gameObject.GetComponent<Rigidbody>().drag = Random.Range(20, 35);
    }
}