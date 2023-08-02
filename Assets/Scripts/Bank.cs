using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public int startingBalance = 100;

    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }

    void Awake()
    {
        currentBalance = startingBalance;
    }

    public void ChangeBalance(int amount)
    {
        currentBalance += amount;
    }
}
