using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool canPlaceTower;

    void OnMouseDown()
    {
        if(canPlaceTower) {
            Debug.Log($"{transform.name} available for tower placement");
        }
        else {
            Debug.Log($"Cannot make a tower here at {transform.name}");
        }
    }
}
