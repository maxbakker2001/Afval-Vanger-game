using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField]
    private float grafity;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Fishnet")
            Destroy(gameObject);
    }

    private void Update()
    {
        grafity = Random.Range(-5, 0.3f);
        transform.Translate(0, grafity * Time.deltaTime, 0, Space.World);
    }
}