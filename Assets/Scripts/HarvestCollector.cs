using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestCollector : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wheatBag")
        {
            Debug.Log("wheat has been collected ..");
        }
    }
}
