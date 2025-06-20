using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offer : MonoBehaviour
{

    //[SerializeField] GameObject
    int Num_of_Requests = 0;
    public string current_request;
    public int Completed_request;
    private List<string> goods = new List<string>() { "bread", "fish" };

    [SerializeField] GameObject Triple;
    [SerializeField] GameObject Double;
    [SerializeField] Animator client1_animator;

    void Start()
    {
        Completed_request = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "client")
        {
            string Item_requested = goods[Random.Range(0, 2)];
            client1_animator.SetBool("request", true);
            if (Item_requested == "bread")
            {
                Double.SetActive(true);
                buy_request(Item_requested);
                Debug.Log("bread Requested..");
            }
            else
            {
                Triple.SetActive(true);
                buy_request(Item_requested);
                Debug.Log("Fish Requested..");
            }
        }
    }

    void buy_request(string item)
    {
        current_request = item;
    }

    void score_system()
    {

    }

}
