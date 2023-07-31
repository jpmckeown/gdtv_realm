using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHitPoints = 5;
    int currentHitPoints = 0;

    void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    void Update()
    {
        // if(currentHitPoints <= 0)
        // {
        //     Destroy();
        // }
    }

    void OnParticleCollision(GameObject other) {
        Debug.Log("Hit by missile from tower " + other.gameObject.name);
        currentHitPoints -= 1;
    }
}
