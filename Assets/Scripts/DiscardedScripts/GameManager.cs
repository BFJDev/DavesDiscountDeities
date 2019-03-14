using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
[System.Serializable]
public class Deity
{
    public Image deityIcon;
    public string GodName;
    public int worshipAmtRequired;
    public WorshipMethod preferredWorshipMethod;

    private int worshipAmtReceived;
    private int satisfaction;
    private List<Cult> worshippingCults;
}
*/
public class GameManager : MonoBehaviour
{
    public string name;
   public List<Deity> deities;
    List<Cult> cults;
    List<Cult> customers;

    // Start is called before the first frame update
    void Start()
    {
       // deities = new List<Deity>();
        cults = new List<Cult>();
        customers = new List<Cult>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDeity()
    {
      //  deities.Add(new Deity("Yagthweep", WorshipMethod.Ritual, 100));
    }

    public void printDeities()
    {
     //   foreach( Deity deity in deities )
        {
          //  Debug.Log(deity.GetName() + " rules all!");
        }

    }

    public void GenerateCustomers()
    {
        int numCustomersToday = Random.Range(1, 5);

        for( int i = 0; i < numCustomersToday; i++ )
        {
            Cult c = new Cult("new cult", WorshipMethod.Ritual, 30);
            customers.Add(c);
        }
    }
}
