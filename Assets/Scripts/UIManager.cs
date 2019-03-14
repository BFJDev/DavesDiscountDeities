using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** UIManager handles all the different panels, windows, and navigation buttons in DDD. AKA "Button Manager", this class
 *  just makes it easier to handle all navigation interactions within the game.
 * 
 */
public class UIManager : MonoBehaviour
{
    //List of buttons from the Main Navigation Panel
    public GameObject MainMenu;
    public GameObject CultMenu;
    public GameObject DeityMenu;
    public GameObject CustomerMenu;
    public GameObject LicenseMenu;
    public GameObject LicensePage;


    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        CultMenu.SetActive(false);
        DeityMenu.SetActive(false);
        CustomerMenu.SetActive( false );
        LicenseMenu.SetActive(false);
        LicensePage.SetActive(false);
        Debug.Log("The game has begun.");
    }

    //What to do when the "Customers" button is pressed
    public void OnCustomerButton()
    {
        Debug.Log("You pressed the \"customers\" button");
        MainMenu.SetActive(true);
        CustomerMenu.SetActive(true);
        CultMenu.SetActive(false);
        DeityMenu.SetActive(false);
        LicenseMenu.SetActive(false);
        LicensePage.SetActive(false);
    }

    //What to do when the "View Cults" button is pressed
    public void OnCultButton()
    {
        Debug.Log("You pressed the \"cults\" button");
        MainMenu.SetActive(true);
        CustomerMenu.SetActive(false);
        CultMenu.SetActive(true);
        DeityMenu.SetActive(false);
        LicenseMenu.SetActive(false);
        LicensePage.SetActive(false);
    }

    //What to do when the "View Deities" button is pressed
    public void OnDeityButton()
    {
        Debug.Log("You pressed the \"deities\" button");
        MainMenu.SetActive(true);
        CustomerMenu.SetActive(false);
        CultMenu.SetActive(false);
        DeityMenu.SetActive(true);
        LicenseMenu.SetActive(false);
        LicensePage.SetActive(false);
    }

    //What to do when the "View Deities" button is pressed
    public void OnLicenseButton()
    {
        Debug.Log("You pressed the \"Sell License\" button");
        MainMenu.SetActive( false);
        CustomerMenu.SetActive(false);
        CultMenu.SetActive(false);
        DeityMenu.SetActive(false);
        LicenseMenu.SetActive(true);
        LicensePage.SetActive(false);
    }

    public void OnLicensePageButton()
    {
        Debug.Log("You pressed the \"Sell License\" button");
        MainMenu.SetActive(false);
        CustomerMenu.SetActive(false);
        CultMenu.SetActive(false);
        DeityMenu.SetActive(false);
        LicenseMenu.SetActive(false);
        LicensePage.SetActive(true);
    }

}
