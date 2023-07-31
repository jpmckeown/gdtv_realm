using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool canPlaceTower;
    [SerializeField] GameObject towerPrefab;

    void OnMouseDown()
    {
        if(canPlaceTower) {
            Debug.Log($"{transform.name} available for tower placement");
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            canPlaceTower = false;
        }
        else {
            Debug.Log($"Cannot make a tower here at {transform.name}");
        }
    }
}
