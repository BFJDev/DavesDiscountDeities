using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LicenseScrollList : MonoBehaviour
{
    public List<Deity> licenseList;
    //  private DeityList deityListScript;

    private List<LicenseButton> buttonList;

    private ObjectManager objManagerScript;

    public LicenseButton buttonToSpawn;

    public GameObject objManager;

    public GameObject content;

    // Start is called before the first frame update
    void Start()
    {
        buttonList = new List<LicenseButton>();
        //Get the deity oracle and add it to the list

        objManagerScript = (ObjectManager)objManager.GetComponent(typeof(ObjectManager));
        licenseList = objManagerScript.GetDeityList();
        Debug.Log(licenseList.Count);
        RefreshDisplay();
    }

    void OnEnable()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        RemoveButtons();
        AddButtons();
    }

    private void RemoveButtons()
    {
        if (buttonList != null)
        {
            foreach (LicenseButton button in buttonList)
            {
                Destroy(button.gameObject);
            }

            buttonList.Clear();
        }

    }

    private void AddButtons()
    {
        if (buttonList == null)
        {
            buttonList = new List<LicenseButton>();
        }

        for (int i = 0; i < licenseList.Count; i++)
        {
            Deity deity = licenseList[i];

            LicenseButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup(deity, this);
            buttonList.Add(button);
        }
    }
}
