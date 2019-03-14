using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public enum MenuStates { Main, Cults, Deities };

    public MenuStates currentMenuState;

    public GameObject MainMenu;
    public GameObject CultMenu;
    public GameObject DeityMenu;
    public GameObject CustomerMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        Debug.Log("The game has begun.");
        currentMenuState = MenuStates.Main;
    }


    public void OnCultButton()
    {
        Debug.Log("You pressed the \"cults\" button");
        CultMenu.SetActive(true);
       // MainMenu.SetActive(false);
        DeityMenu.SetActive(false);
        CustomerMenu.SetActive(false);
    }

    public void OnDeityButton()
    {
        Debug.Log("You pressed the \"deities\" button");
        CultMenu.SetActive( false );
      //  MainMenu.SetActive(false);
        DeityMenu.SetActive( true );
        CustomerMenu.SetActive(false);
    }

    public void OnCustomerButton()
    {
        Debug.Log("You pressed the \"customers\" button");
        CultMenu.SetActive( false );
        DeityMenu.SetActive( false );
        CustomerMenu.SetActive(true);
    }

}