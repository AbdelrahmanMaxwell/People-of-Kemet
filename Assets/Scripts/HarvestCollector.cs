using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestCollector : MonoBehaviour
{
    public int Bags_collected;

    void Start()
    {
        Bags_collected = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wheatBag")
        {
            Debug.Log("wheat has been collected ..");
            Bags_collected++;
        }

        if (Bags_collected == 3)
        {
            Debug.Log("Mission is Completed ..");
        }
    }
}
