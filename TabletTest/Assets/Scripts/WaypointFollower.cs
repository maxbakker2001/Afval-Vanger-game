using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public float platformSpeed;

    public GameObject[] Waypoints;
    [SerializeField] private int CurrentWaypoint = 0;

    private void Update()
    {
        if (Vector3.Distance(Waypoints[CurrentWaypoint].transform.position, transform.position) < .1f)
        {
            CurrentWaypoint++;
            if (CurrentWaypoint >= Waypoints.Length)
            {
                CurrentWaypoint = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentWaypoint].transform.position, Time.deltaTime * platformSpeed);
    }
}