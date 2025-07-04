using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheatseed : MonoBehaviour
{
    [SerializeField] float growth_speed = 22f;
    bool water_pured = false;

    [SerializeField] GameObject water_liquid;
    [SerializeField] GameObject wheat;

    [SerializeField] AudioSource waterSFX;

    // Update is called once per frame
    void Update()
    {

        if (water_pured && transform.localScale.y <= 241)
        {
            Vector3 currentScale = transform.localScale;
            currentScale.y += growth_speed * Time.deltaTime;
            transform.localScale = currentScale;

        }

        if (transform.localScale.y >= 240)
        {
            this.gameObject.SetActive(false);
            wheat.SetActive(true);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "water")
        {
            water_pured = true;
            other.tag = "Untagged";
            waterSFX.Play();
            water_liquid.SetActive(false);
        }
    }
}
