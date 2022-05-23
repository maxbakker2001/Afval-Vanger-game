using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public float MoveSpeed;

    public bool RandomWaypointPicker = false;

    [SerializeField] private int CurrentWaypoint = 0;
    [SerializeField] private GameObject[] Waypoints;

    private void Start()
    {
        //adds all waypoints in the scene to the array
        Waypoints = GameObject.FindGameObjectsWithTag("Waypoints");
    }

    private void Update()
    {
        if (RandomWaypointPicker == true)
        {
            RandomWaypoint();
        }
        else
        {
            looping();
        }

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentWaypoint].transform.position, Time.deltaTime * MoveSpeed);
    }

    private void RandomWaypoint()
    {
        //moving to random waypoint
        if (Vector3.Distance(Waypoints[CurrentWaypoint].transform.position, transform.position) < .1f)
        {
            CurrentWaypoint = Random.Range(0, Waypoints.Length);
        }

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentWaypoint].transform.position, Time.deltaTime * MoveSpeed);
    }

    private void looping()
    {
        //looping waypoints
        if (Vector3.Distance(Waypoints[CurrentWaypoint].transform.position, transform.position) < .1f)
        {
            CurrentWaypoint++;
            if (CurrentWaypoint >= Waypoints.Length)
            {
                CurrentWaypoint = 0;
            }
        }
    }
}