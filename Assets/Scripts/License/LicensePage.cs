using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LicensePage : MonoBehaviour
{
    public Text GodNameText;

    public Button GoldenSellButton;
    
    public ObjectManager objManager;

    private Cult CurrentCult;

    private Deity CurrentDeity;

    // Start is called before the first frame update
    void Start()
    {
        GoldenSellButton.onClick.AddListener(delegate { AddCult(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCult()
    {
        Debug.Log("Status #2: " + CurrentCult.GetLeaderName());
        objManager.AddCult( CurrentDeity, CurrentCult);
    }

    public void PopulateLicensePage( Deity deity, Cult cult )
    {
        CurrentCult = cult;
        CurrentDeity = deity;

        GodNameText.text = deity.GetName();
    }


}
