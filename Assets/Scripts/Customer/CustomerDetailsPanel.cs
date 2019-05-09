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
        SellLicenseButton.onClick.AddListener(delegate { SellLicense(); });

        ldpScript = (LicenseDetailsPanel)ldpObject.GetComponent(typeof(LicenseDetailsPanel));
    }

    public void populateDetailsPanel( Cult cult )
    {
        CurrentSelectedCult = cult;

        customerName.text = "Leader: " + cult.GetLeaderName();
        customerSize.text = "Members: " + cult.GetSize();
        preferredWorshipMethod.text = "Worship Method: " + cult.GetWorshipMethod();

    }

    public void SellLicense()
    {
        ldpScript.populateDetailsPanelByCustomer(CurrentSelectedCult);
    }

}
