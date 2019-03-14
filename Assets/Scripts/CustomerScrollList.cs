using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerScrollList : MonoBehaviour
{
    public List<Cult> customerList;

    private List<CustomerButton> buttonList;

    public CustomerButton buttonToSpawn;

    public GameObject content;

    public GameObject detailsPanel;

    public GameObject objManager;

    public ObjectManager objectManager;

    //private List<string> LeaderNames = new List<string> { "John", "Lauren", "Ishan" };


    //public Transform contentPanel;
    //public CultScrollList otherList;
    //public SimpleObjectPool buttonObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        customerList = new List<Cult>();
       // buttonList = new List<CustomerButton>();
        objectManager = (ObjectManager)objManager.GetComponent(typeof(ObjectManager));
       // RefreshDisplay();
    }

    void OnEnable()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        RemoveButtons();
        RetrieveCustomerList();
        AddButtons();
    }

    private void RetrieveCustomerList()
    {
        customerList = objectManager.GetCustomerList();
        Debug.Log("Retrieved Customer List. New List has Size: " + customerList.Count);
    }

    private void RemoveButtons()
    {
        if (buttonList != null)
        {
            Debug.Log("# of objects in CustomerButtonList: " + buttonList.Count);
            foreach (CustomerButton button in buttonList)
            {
                Destroy(button.gameObject);
            }

            buttonList.Clear();
            Debug.Log("# of objects in CustomerButtonList (post-removal): " + buttonList.Count);
        }

    }

    private void AddButtons()
    {
        if (buttonList == null)
        {
            buttonList = new List<CustomerButton>();
        }
        for (int i = 0; i < customerList.Count; i++)
        {
            Cult cult = customerList[i];

            CustomerButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup(cult, this);
            buttonList.Add(button);
            Debug.Log("Button added. I now have " + buttonList.Count + " customer buttons");

            //   var copy = Instantiate(itemTemplate);
            //   copy.transform.SetParent(content.transform, false);
            //   copy.transform.localPosition = Vector3.zero;

            //    GameObject newButton = buttonObjectPool.GetObject();
            //   newButton.transform.SetParent(contentPanel);

            //    CultButton button = newButton.GetComponent<CultButton>();
            //   button.Setup( cult, this );
        }
    }

  /*  public void GenerateCustomers()
    {
        Debug.Log(LeaderNames.Count);
        int numCustomersToday = Random.Range(1, 4);
        Debug.Log("ring a ling! today you have x customers: " + numCustomersToday);
        for (int i = 1; i <= numCustomersToday; i++)
        {
            Debug.Log( i + ": adding x's cult to the game:" + LeaderNames[i - 1] );
            Cult c = new Cult( LeaderNames[ i - 1 ], LeaderNames[i - 1] + "'s Followers", WorshipMethod.Ritual, 30);
            customerList.Add(c);
        }
    }*/

    public GameObject GetDetailsPanel()
    {
        return detailsPanel;
    }

}
