using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerButton : MonoBehaviour
{
    public Button button;
    public Text customerName;
 //   public Text customerCultSize;
//    public Text preferredWorshipMethod;

    private Cult cult;
    private CustomerScrollList customerScrollList;
    private GameObject detailsPanel;

    public void Setup(Cult c, CustomerScrollList scrollList)
    {
          cult = c;
          customerName.text = cult.GetLeaderName();
 //       preferredWorshipMethod.text = c.GetWorshipMethod();
 //       cultSize.text = cult.GetSize().ToString();

        customerScrollList = scrollList;
        detailsPanel = GameObject.Find("Customer Details Panel");
        button.onClick.AddListener(delegate { fillPanel(); });
        
    }

    public void fillPanel()
    {
        detailsPanel.GetComponent<CustomerDetailsPanel>().populateDetailsPanel( cult ); 
    }

    /*
      void Start ()
      {
          ButtonPre.onClick.AddListener(delegate{SwitchButtonHandler(0);});
          ButtonNext.onClick.AddListener(delegate{SwitchButtonHandler(1);});
      }
  
      void SwitchButtonHandler(int idx_)
      {
          //Here i want to know which button was Clicked.
          //or how to pass a param through addListener
      } 
     * */
    }
