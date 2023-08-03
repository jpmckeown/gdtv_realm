using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 75;

    int towerCount = 0;

    void Awake()
    {
        towerCount = 0;
    } 

    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();

        if(bank == null) { return false; } 

        if(bank.CurrentBalance >= cost)
        {
            var obj = Instantiate(tower, position, Quaternion.identity);
            obj.name = "Tower " + towerCount;
            bank.loss(cost);
            towerCount += 1;
            return true;    
        }

        return false;
    }
}
