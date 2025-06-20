using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat_plant : MonoBehaviour
{

    [SerializeField] GameObject wheatBag;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sickle")
        {
            this.gameObject.SetActive(false);
            wheatBag.SetActive(true);
        }
    }
}
