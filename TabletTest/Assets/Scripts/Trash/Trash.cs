using UnityEngine;

public class Trash : MonoBehaviour

{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
    }
}