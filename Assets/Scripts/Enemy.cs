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

    public void rewardGold()
    {
        if(bank == null) { return; }
        bank.gain(reward);
    }

    public void stealGold()
    {
        if(bank == null) { return; }
        bank.loss(penalty);
    }
}
