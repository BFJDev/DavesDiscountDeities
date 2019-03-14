using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerDetailsPanel : MonoBehaviour
{
    public Text customerName;
    public Text customerSize;
    public Text preferredWorshipMethod;

    public Button SellLicenseButton;

    private GameObject detailsPanel;

    public GameObject CustomerScrollPanel;
    public GameObject DeitySelectPanel;
    public GameObject CustomerDetailsPanelObject;

    public GameObject ldpObject;
    private LicenseDetailsPanel ldpScript;

    private Cult CurrentSelectedCult;

    void Start()
    {
       // Debug.Log(" Start called for Customer Management System");
        //        button.onClick.AddListener(delegate { fillPanel(); });

        SellLicenseButton.onClick.AddListener(delegate { SellLicense(); });

        ldpScript = (LicenseDetailsPanel)ldpObject.GetComponent(typeof(LicenseDetailsPanel));
    }

    public void populateDetailsPanel( Cult cult )
    {
        CurrentSelectedCult = cult;

        customerName.text = "Leader: " + cult.GetLeaderName();
        customerSize.text = "Size:" + cult.GetSize();
        preferredWorshipMethod.text = "Worship Method: " + cult.GetWorshipMethod();

     //   sellLicenseButton.GetComponent<SellLicense>();
    }

    public void SellLicense()
    {
        ldpScript.populateDetailsPanelByCustomer(CurrentSelectedCult);
    }

}
