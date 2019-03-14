using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LicenseButton : MonoBehaviour
{
    public Button button;
    public Text deityName;
    public GameObject LicenseDetailsPanel; 
    // public Text preferredWorshipMethod;

    private Deity deity;
    private LicenseScrollList licenseScrollList;


  //  private GameObject LicenseDetailsPanel;

    public void Setup(Deity d, LicenseScrollList scrollList)
    {
        deity = d;
        deityName.text = deity.GetName();
        // deityIcon = deity.GetDeityIcon();
        //   cultSize.text = cult.GetSize().ToString();

        licenseScrollList = scrollList;
       // DetailsPanel = GameObject.Find("Deity Details Panel");
        button.onClick.AddListener(delegate { fillPanel(); });
    }

    public void fillPanel()
    {
        LicenseDetailsPanel.GetComponent<LicenseDetailsPanel>().populateDetailsPanelByDeity(deity);
    }
}
