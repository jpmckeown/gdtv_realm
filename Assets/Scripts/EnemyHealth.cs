using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    public int maxHitPoints = 3;
    [SerializeField] int currentHitPoints = 0;

    [Tooltip("Raises maximum hitpoints when enemy killed")]
    [SerializeField] int difficultyRamp = 1;

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other) {
        Debug.Log("Hit by missile from tower " + other.gameObject.name);
        HitResult();
    }

    void HitResult()
    {
        currentHitPoints -= 1;
        
        if(currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            enemy.rewardGold();
            maxHitPoints += difficultyRamp;
        }
    }
}
