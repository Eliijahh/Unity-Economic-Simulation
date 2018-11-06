using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auction : MonoBehaviour
{

    List<Requests> bidRequests = new List<Requests>();
    List<Requests> askRequests = new List<Requests>();

    public class Requests
    {
        float price;
        int quantity;
        enum Type { ask, bid };

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
