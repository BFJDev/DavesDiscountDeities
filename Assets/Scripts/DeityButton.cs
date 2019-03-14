using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeityButton : MonoBehaviour
{
    public Button button;
    public Text deityName;
   // public Text preferredWorshipMethod;

    private Deity deity;
    private DeityScrollList deityScrollList;

    private GameObject DetailsPanel;

    public void Setup(Deity d, DeityScrollList scrollList)
    {
        deity = d;
        deityName.text = deity.GetName();
       // deityIcon = deity.GetDeityIcon();
     //   cultSize.text = cult.GetSize().ToString();

        deityScrollList = scrollList;
        DetailsPanel = GameObject.Find("Deity Details Panel");
        button.onClick.AddListener(delegate { fillPanel(); });
    }

    public void fillPanel()
    {
        DetailsPanel.GetComponent<DeityDetailsPanel>().populateDetailsPanel(deity);
    }
}
