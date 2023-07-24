using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        pr();
    }

    void pr()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
        }
    }
}
