using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LicenseDetailsPanel : MonoBehaviour
{

    public Text CultWorshipMethod;
    public Text DeityWorshipMethod;

    public Slider WorshipLevelSlider;

    private GameObject detailsPanel;

    private Deity currentDeity;
    private Cult currentCustomer;

    public Button SellLicenseButton;

    public LicensePage LicensePage;
    private LicensePage LicensePageScript;

    void Start()
    {
        SellLicenseButton.onClick.AddListener(delegate { PopulateLicensePage(); });

        LicensePageScript = (LicensePage)LicensePage.GetComponent(typeof(LicensePage));
    }

    public void populateDetailsPanelByCustomer( Cult cult )
    {
        Debug.Log( "" + cult.GetWorshipMethod() );

        currentCustomer = cult;
        CultWorshipMethod.text = "" + cult.GetWorshipMethod();

    }

    public void populateDetailsPanelByDeity(Deity deity)
    {
        currentDeity = deity;
        DeityWorshipMethod.text = "" + deity.GetWorshipMethod();

        WorshipLevelSlider.value = CalculateWorshipLevel() / currentDeity.GetWorshipRequired();
    }

    public float CalculateWorshipLevel()
    {
        if (currentCustomer == null)
            return 0f;

        if (currentCustomer.GetWorshipMethod() == currentDeity.GetWorshipMethod())
        {
         //   Debug.Log(currentDeity.GetWorshipReceived() + (((float)currentCustomer.GetSize()) * currentCustomer.GetFaith()));
            return currentDeity.GetWorshipReceived() + (((float)currentCustomer.GetSize()) * currentCustomer.GetFaith());
        }
        else
            return currentDeity.GetWorshipReceived() + (((float)currentCustomer.GetSize()) * currentCustomer.GetFaith() * 0.7f);

    }

    public void PopulateLicensePage()
    {
        Debug.Log("Status: " + currentCustomer.GetLeaderName());
        LicensePage.PopulateLicensePage(currentDeity, currentCustomer);
    }
}
