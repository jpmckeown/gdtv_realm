using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    
    [SerializeField] bool canPlaceTower;
    public bool CanPlaceTower { get{return canPlaceTower;} } // property

    void OnMouseDown()
    {
        if(canPlaceTower) {
            // Debug.Log($"{transform.name} available for tower placement");
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            canPlaceTower = !isPlaced; 
        }
        else {
            Debug.Log($"Cannot make a tower here at {transform.name}");
        }
    }
}
