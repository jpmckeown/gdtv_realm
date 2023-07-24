using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordLabeller : MonoBehaviour
{
    TextMeshPro label;

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
        }
    }

    void DisplayCoordinates()
    {
        label.text = "--,--";
    }
}
