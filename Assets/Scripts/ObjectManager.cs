using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public UIManager UIManager;

    private int day = 1;
    public Text DayText;

    //Level of advertisement the store is currently receiving. Can be any number from 1-10
    //Level 0 = 1-3 daily customers
    //Level 1 = 2-4 daily customers
    //Level 2 = 3-5 daily customers
    //Level 3 = 4-6 daily customers
    //Level 4 = 5-7 daily customers
    private float AdvertisementLevel;


    //private List<string> LeaderNames = new List<string> { "John", "Lauren", "Ishan", "Amy", "Emily", "Nina", "Jeremy", "Parker", "Justine", "Cam", "Graham", "Ragan", "Gail", "Matt", "Joseph", "Tony", "Burnie", "Zach", };
    //List of first names to use when generating leader names
    //Male Names: 9
    //Female Names: 7
    //Neutral Names: 5
    private List<string> FirstNames = new List<string> { "Amy", "Ashley", "Alex", "Ben", "Emily", "Cameron", "Dave", "Gail", "Gus", "Ishan", "Jeremy", "John", "Justine", "Lauren", "Liliana", "Parker", "Sam", "Tyler", "Winona", "Zach" };
    //List
    private List<string> LastNames = new List<string> { "Johnson", "Wilson", "Bell", "Garrett", "Stone", "Matthews", "Rowe", "Wood" };
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Creating Customers!");
        CreateStartingCustomers();
        AdvertisementLevel = 2;

        DayText.text = "" + day;
    }

    void StartDay()
    {
        Debug.Log("Creating Customers!");
        CreateCustomers();
        DayText.text = "" + day;
    }

    //Spawn Customers for the first day of work! (Day 1)
    //This will be the tutorial level?
    public void CreateStartingCustomers()
    {
        Customers = new List<Cult>();

        //Start the game with the same 3 leaders: John, Ishan, and Lauren
        Customers.Add(new Cult("John Casabonne", WorshipMethod.Ritual, 20));
        Customers.Add(new Cult("Lauren Calhoun", WorshipMethod.Pilgrimage, 20));
        Customers.Add(new Cult("Ishan Jolly", WorshipMethod.Festival, 20));
        /*
        int numCustomersToday = 3;//Random.Range(1, 4);
        Debug.Log("ring a ling! today you have x customers: " + numCustomersToday);
        for (int i = 1; i <= numCustomersToday; i++)
        {
            Debug.Log(i + ": adding x's cult to the game:" + StartingLeaders[i - 1]);
            Cult c = new Cult(StartingLeaders[i - 1], StartingLeaders[i - 1] + "'s Followers", WorshipMethod.Ritual, 20 );
            Customers.Add(c);
        }*/

        for( int i = 0; i < 3; i++ )
        {
            Debug.Log( Customers[i].GetLeaderName() );
        }
    }

    //Generate a list of customers visiting the store today
    public void CreateCustomers()
    {
        Customers.Clear();

        //Determine # of customers based on level of advertisement
        int numCustomersToday = Random.Range( Mathf.FloorToInt( AdvertisementLevel ) + 1, Mathf.FloorToInt(AdvertisementLevel) + 3);
        
        for( int i = 0; i < numCustomersToday; i++ )
        {
            //Generate a cult leader name
            string name = FirstNames[Random.Range(0, FirstNames.Count - 1)] + " " + LastNames[Random.Range(0, LastNames.Count - 1)];

            //Give the customer cult a random WorshipMethod
            WorshipMethod wm;

            int idx = Random.Range(1, 4);
            if (idx == 1)
                wm = WorshipMethod.Festival;
            else if (idx == 2)
                wm = WorshipMethod.Idol;
            else if (idx == 3)
                wm = WorshipMethod.Pilgrimage;
            else
                wm = WorshipMethod.Ritual;

            //Generate a random number for the leader's # of followers
            int members = Random.Range(15, 45);

            Customers.Add(new Cult(name, wm, members));
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
        Debug.Log("OB Manager knows of: " + Deities.Count + " deities");
        return Deities;
    }

    public void AddCult( Deity deity, Cult cult )
    {
        Debug.Log("cult is added to OM");
        Debug.Log("Status #3: " + cult.GetLeaderName());
        Cults.Add(cult);
        deity.addCult(cult);
        Customers.Remove(cult);

        UIManager.OnCustomerButton();

        for(  int i = 0; i < Deities.Count; i++ )
        {
            Debug.Log("Number of worshippers for " + Deities[i].GetName() + ": " + Deities[i].GetWorshippingCults().Count);
        }
    }

    public void EndDay()
    {
        day += 1;
        AdvertisementLevel -= 0.5f;
        if (AdvertisementLevel < 0)
            AdvertisementLevel = 0.0f;

        StartDay();
    }
}
