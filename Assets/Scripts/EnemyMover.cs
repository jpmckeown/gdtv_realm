using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
            yield return new WaitForSeconds(1f);
        }
    }
}
