using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EconomyBehaviour : MonoBehaviour 
{

    private class EconomicEntity : MonoBehaviour
    {
        float money;
        int inventory;

        private produceCommodities()
        {


        }

        

    }

    private class Planet : EconomicEntity 
    {

    }

    private class Company : EconomicEntity 
    {

    }

    // Use this for initialization
    void Start () 
    {
        Application.targetFrameRate = 60;

       
	}
	
	// Update is called once per frame
	void Update () 
    {

        //for round ← 1 to number - of - rounds
        //for each trading agent
        //do perform production
        //generate offers
        //resolve offers

    }
}
