using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeityDetailsPanel : MonoBehaviour
{
    public Text DeityName;

    public Text WorshipMethod;

    public float amtWorshipReceived = 0f;

    public float amtWorshipRequired = 0f;

    public float satisfaction = 65f;

    public Slider WorshipLevelSlider;

    //SatisfactionSlider.value = CalculateSatisfaction();
    public Slider SatisfactionSlider;

    private GameObject detailsPanel;

    private Deity currentDeity;

    public void populateDetailsPanel(Deity deity )
    {
        currentDeity = deity;
        DeityName.text = deity.GetName();
        WorshipMethod.text = "" + deity.GetWorshipMethod();
        amtWorshipRequired = deity.GetWorshipRequired();
        amtWorshipReceived = deity.GetWorshipReceived();
        satisfaction = deity.GetSatisfaction();

        SatisfactionSlider.value = CalculateSatisfaction();
        WorshipLevelSlider.value = CalculateWorshipLevel();
    }

    /*
        // Start is called before the first frame update
        void Start()
        {
            satisfaction = 0f;

            SatisfactionMeter.value = CalculateSatisfaction();
        }

        // Update is called once per frame
        void Update()
        {
            satisfaction += 1f;
            SatisfactionMeter.value = CalculateSatisfaction();
        }
        */
    public float CalculateSatisfaction()
    {
        return satisfaction / 100f;
    }

    public float CalculateWorshipLevel()
    {
        return amtWorshipReceived / amtWorshipRequired;
    }
}
