using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmTut : MonoBehaviour
{
    [SerializeField] GameObject Human;
    [SerializeField] GameObject Tut_UI;
    [SerializeField] GameObject Start_Btn;
    [SerializeField] AudioSource Audio1;
    [SerializeField] AudioSource Audio2;

    void Start()
    {
        StartCoroutine(play_Tut());
    }
    
    IEnumerator play_Tut()
    {
        yield return new WaitForSeconds(3f);
        Human.SetActive(true); Tut_UI.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Audio1.Play();
        yield return new WaitForSeconds(12f);
        Audio2.Play();
        yield return new WaitForSeconds(15f);

        Start_Btn.SetActive(true);
    }

    public void start_game()
    {
        Human.SetActive(false); Tut_UI.SetActive(false);
    }
}
