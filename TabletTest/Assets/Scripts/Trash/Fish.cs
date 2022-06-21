using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public GameObject closest;
    public float speed = 0.5f;
    float distance = 1;
  
    void Update()
    {
        if (closest != null && closest.transform.position.y <= 0.6f)
        {
            transform.position = Vector3.MoveTowards(transform.position, closest.transform.position, speed * Time.deltaTime);
        }
        else
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        FindClosestTrash();

        if (gameObject.transform.position.x >= 2.5f)
            Destroy(gameObject);
    }


    public void FindClosestTrash()
    {
        GameObject[] trash;
        trash = GameObject.FindGameObjectsWithTag("trash");
        closest = null;
        Vector3 position = transform.position;
        foreach (GameObject i in trash)
        {
            Vector3 diff = i.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = i;
                distance = curDistance;
            }
        }
    }



 
}
