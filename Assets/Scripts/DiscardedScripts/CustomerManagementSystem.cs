using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomerManagementSystem : MonoBehaviour
{
    public GameObject CustomerScrollPanel;
    public GameObject DeitySelectPanel;
    public GameObject CustomerDetailsPanel;

    private Cult CurrentSelectedCult;

    public Button SellLicenseButton;

    void Start()
    {
        Debug.Log(" Start called for Customer Management System");
        //        button.onClick.AddListener(delegate { fillPanel(); });

        SellLicenseButton.onClick.AddListener(delegate { SellLicense(); });
    }

    public void SellLicense()
    {
        //Disable Customer Scroll Panel and Customer Details Panel
        CustomerScrollPanel.SetActive(false);
        CustomerDetailsPanel.SetActive(false);

        //Turn on deity select panel
        DeitySelectPanel.SetActive(true);
    }
}
