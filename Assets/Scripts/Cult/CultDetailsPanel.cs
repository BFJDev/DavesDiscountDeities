using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        DeityName.text = cult.getDeityName();

        LeaderName.text = cult.GetLeaderName();
        CultSize.text = "" + cult.GetSize();
        WorshipMethod.text = " " + cult.GetWorshipMethod();

        float faith = cult.GetFaith();

        FaithSlider.value = faith;
    }

}
