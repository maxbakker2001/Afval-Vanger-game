using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FloatingScript : MonoBehaviour
{
    [Header("Water Settings")]
    public float waterHeight = 0f;

    public float UnderwaterDrag = 3;
    public float UnderwaterAngularDrag = 1;
    public float FloatingPower = 15f;

    [Header("Air Settings")]
    public float AirDrag = 0f;

    public float AirAngularDrag = 0.05f;

    [Header("Waypoint Settings")]
    public float WaypointMoveSpeed;

    public GameObject[] Waypoints;
    [SerializeField] private int CurrentWaypoint = 0;

    private Rigidbody m_rigidbody;

    private bool underwater;

    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

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

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentWaypoint].transform.position, Time.deltaTime * WaypointMoveSpeed);
    }

    private void FixedUpdate()
    {
        float difference = transform.position.y - waterHeight;
        if (difference < 0)
        {
            m_rigidbody.AddForceAtPosition(Vector3.up * FloatingPower * Mathf.Abs(difference), transform.position, ForceMode.Force);
            if (!underwater)
            {
                underwater = true;
                SwitchState(true);
            }
        }
        else if (underwater)
        {
            underwater = false;
            SwitchState(false);
        }
    }

    private void SwitchState(bool Isunderwater)
    {
        if (Isunderwater)
        {
            m_rigidbody.drag = UnderwaterDrag;
            m_rigidbody.angularDrag = UnderwaterAngularDrag;
        }
        else
        {
            m_rigidbody.drag = AirDrag;
            m_rigidbody.angularDrag = AirAngularDrag;
        }
    }
}