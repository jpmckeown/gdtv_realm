using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int reward = 25;
    [SerializeField] int penalty = -25;

    Bank bank;

    void Start()
    {
        bank = FindObjectOfType<Bank>();

    }

    public void rewardKill()
    {
        if(bank == null) { return; }
        bank.ChangeBalance(reward);
    }

    public void enemySteals()
    {
        if(bank == null) { return; }
        bank.ChangeBalance(penalty);
    }

    void Update()
    {
        
    }
}
