using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demand : MonoBehaviour
{

    //[SerializeField] GameObject
    public int Num_offer_goods;

    [SerializeField] Offer offer;

    [SerializeField] List<GameObject> clients = new List<GameObject>();
    public int client_order;

    public bool motionActive = true;


    //Test [instead of UI button for now]
    [SerializeField] public bool finish = false;

    void Start()
    {
        Num_offer_goods = 0;
        client_order = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (clients[client_order].activeSelf && motionActive)
        {
            clients[client_order].transform.localPosition -= new Vector3(0f,0f,0.008f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bread")
        {
            //Debug.Log("Bread Included ..");
            other.tag = "Untagged";
            Num_offer_goods++;
        }

        if (other.tag == "fish")
        {
            //Debug.Log("Bread Included ..");
            other.tag = "Untagged";
            Num_offer_goods++;
        }
    }

    public void finish_trade_process()
    {
        if (offer.current_request == "bread" && Num_offer_goods == 3)
        {
            Debug.Log("Process Completed successfully");
            offer.Double.SetActive(false);
            offer.Completed_request++;
        }
        else if (offer.current_request == "fish" && Num_offer_goods == 1)
        {
            Debug.Log("Process Completed successfully");
            offer.Triple.SetActive(false);
            offer.Completed_request++;
        }
        else
        {
            Debug.Log("Process Incompleted!!");
        }

        clients[client_order].SetActive(false);
        Num_offer_goods = 0;
        client_order++;
        if (client_order == 3)
        {
            Debug.Log(offer.Completed_request);
        }
        else
        {
            clients[client_order].SetActive(true);
            motionActive = true;
        }
    }
}
