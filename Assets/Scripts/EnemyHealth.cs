using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHitPoints = 5;
    [SerializeField] int currentHitPoints = 0;

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {

    }

    void OnParticleCollision(GameObject other) {
        Debug.Log("Hit by missile from tower " + other.gameObject.name);
        currentHitPoints -= 1;
        if(currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            enemy.rewardGold();
        }
    }
}
