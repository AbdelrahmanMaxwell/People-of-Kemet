using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] GameObject water;

    void OnTriggerEnter(Collider other)
    {
        other.tag = "water";
        water.SetActive(true);
    }   
}
