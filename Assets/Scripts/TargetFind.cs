using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFind : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] Transform target;

    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}