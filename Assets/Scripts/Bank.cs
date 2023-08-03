using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 100;

    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance; } }

    [SerializeField] TextMeshProUGUI displayBalance;   

    void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }

    public void gain(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void loss(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateDisplay();

        if(currentBalance < 0)
        {
            // lose game
            RelaodScene();
        }
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    void RelaodScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
