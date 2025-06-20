using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketTut : MonoBehaviour
{

    [SerializeField] GameObject Human;
    [SerializeField] GameObject Tut_UI;
    [SerializeField] GameObject Start_Btn;
    [SerializeField] AudioSource AudioOpening;
    [SerializeField] AudioSource Audio1;
    [SerializeField] AudioSource Audio2;

    [SerializeField] GameObject LightSource;


    void Start()
    {
        StartCoroutine(play_Tut());
        LightSource.transform.eulerAngles = new Vector3(40, 115f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator play_Tut()
    {
        yield return new WaitForSeconds(3f);
        Human.SetActive(true); Tut_UI.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        AudioOpening.Play();
        yield return new WaitForSeconds(8f);
        Audio1.Play();
        yield return new WaitForSeconds(12f);
        Audio2.Play();
        yield return new WaitForSeconds(6f);

        Start_Btn.SetActive(true);
    }

    public void start_game()
    {
        Human.SetActive(false); Tut_UI.SetActive(false);
    }

    

}
