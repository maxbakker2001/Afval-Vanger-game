using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField]
    private float grafity;
    public  bool grav;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fishnet")
            Destroy(gameObject);
    }

    private void Awake()
    {
        gameObject.GetComponent<Rigidbody>().drag = Random.Range(20, 35);
    }

}