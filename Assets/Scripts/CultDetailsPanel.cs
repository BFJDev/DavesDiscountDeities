using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CultDetailsPanel : MonoBehaviour
{
    public Text LeaderName;
    public Text DeityName;
    public Text WorshipMethod;
    public Text CultSize;

    public Slider FaithSlider;

    private GameObject detailsPanel;

    private Cult CurrentSelectedCult;

    void Start()
    {
        
    }

    public void populateDetailsPanel(Cult cult)
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
