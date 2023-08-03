using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFind : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] ParticleSystem projectilePfx;
    [SerializeField] float range = 15f;
    [SerializeField] Transform target;

    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Debug.Log(this.name + " sees " + enemies.Length + " enemies");

        // none identified yet
        Transform closestTarget = null;
        float maxDistance = Mathf.Infinity;

        foreach(Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if(targetDistance < maxDistance)
            {
                closestTarget = enemy.transform;
                maxDistance = targetDistance;
            }
        }
        target = closestTarget;
        Debug.Log(target.name + " is closest");
    }

    void AimWeapon()
    {
        float targetDistance = Vector3.Distance(transform.position, target.position);
        
        weapon.LookAt(target);
        
        if(targetDistance < range)
        {
            Attack(true);
            // Debug.Log($"{target.name} is in range {targetDistance}, firing!");
        } 
        else {
            Attack(false);
            // Debug.Log($"{target.name} out of range {targetDistance}");
        }
    }

    void Attack(bool isPrimed)
    {     
        var emissionModule = projectilePfx.emission;
        emissionModule.enabled = isPrimed;
    }
}
