using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject intruder;

    void Start()
    {
        StartCoroutine(MakeIntruders());
    }

    void Update()
    {
        
    }

    void MakeIntruders()
    {
        
        Instantiate(intruder, transform.position, Quaternion.identity);
        yield return(1) ;
    }
}
