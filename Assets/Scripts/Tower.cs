using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // [SerializeField] int cost = 75;

    public bool CreateTower(Tower tower, Vector3 position)
    {
        // Bank bank = FindObjectOfType<bank>();

        // if(bank == null) { return; } 

        Instantiate(tower, position, Quaternion.identity);
        return true;
    }
}
