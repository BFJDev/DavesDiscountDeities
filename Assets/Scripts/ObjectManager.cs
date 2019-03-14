﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Object Manager is for creating + storing all in-game Customers, Cults, Deities, and other
 * objects that may appear in-game.
 *
 */
public class ObjectManager : MonoBehaviour
{
    public List<Cult> Customers;
    public List<Cult> Cults;
    public List<Deity> Deities;


    private List<string> LeaderNames = new List<string> { "John", "Lauren", "Ishan" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating Customers!");
        CreateCustomers();
    }

    //Spawn Customers for the day
    public void CreateCustomers()
    {
        Customers = new List<Cult>();

        Debug.Log(LeaderNames.Count);
        int numCustomersToday = 3;//Random.Range(1, 4);
        Debug.Log("ring a ling! today you have x customers: " + numCustomersToday);
        for (int i = 1; i <= numCustomersToday; i++)
        {
            Debug.Log(i + ": adding x's cult to the game:" + LeaderNames[i - 1]);
            Cult c = new Cult(LeaderNames[i - 1], LeaderNames[i - 1] + "'s Followers", WorshipMethod.Ritual, Random.Range(5, 101) );
            Customers.Add(c);
        }
    }

    //Return the list of stored Customers
    public List<Cult> GetCustomerList()
    {
        return Customers;
    }

    //Return the list of stored Cults
    public List<Cult> GetCultList()
    {
        return Cults;
    }

    //Return the list of stored Deities
    public List<Deity> GetDeityList()
    {
        return Deities;
    }
}
