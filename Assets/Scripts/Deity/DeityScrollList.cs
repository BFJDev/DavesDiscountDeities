using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeityScrollList : MonoBehaviour
{
    public List<Deity> deityList;
    private DeityList deityListScript;

    private List<DeityButton> buttonList;

    private ObjectManager objManagerScript;

    public DeityButton buttonToSpawn;

    public ObjectManager objManager;

    public GameObject content;

    // Start is called before the first frame update
    void Start()
    {
        //Get the deity oracle and add it to the list

        /*   GameObject oracle = GameObject.Find("DeityOracle");
           deityListScript = (DeityList)oracle.GetComponent(typeof(DeityList));
           deityList = deityListScript.GetDeityList();*/
        deityList = new List<Deity>();

        //buttonList = new List<DeityButton>();
        objManagerScript = (ObjectManager)objManager.GetComponent(typeof(ObjectManager));
       // deityList = objManagerScript.GetDeityList();
       // Debug.Log( deityList.Count );
       // RefreshDisplay();
    }

    void OnEnable()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        RemoveButtons();
        RetrieveDeityList();
        AddButtons();
    }

    private void RetrieveDeityList()
    {
        deityList = objManager.GetDeityList();
        Debug.Log("Retrieved Deity List. New List has Size: " + deityList.Count);
    }

    private void RemoveButtons()
    {
 /*       if (buttonList == null)
        {
            Debug.Log("Button list initialized in RemoveButtons()");
            buttonList = new List<DeityButton>();
        }
        else
        {
            Debug.Log("# of objects in DeityButtonList: " + buttonList.Count);
            foreach (DeityButton button in buttonList)
            {
                Destroy(button.gameObject);
            }
            buttonList.Clear();
            Debug.Log("# of objects in DeityButtonList (post-removal): " + buttonList.Count);
        }*/

        if( buttonList != null )
        {
            foreach (DeityButton button in buttonList)
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
            Debug.Log("Button list initialized in AddButtons()");
            buttonList = new List<DeityButton>();
        }
        for (int i = 0; i < deityList.Count; i++)
        {
            Deity deity = deityList[i];

            DeityButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup( deity , this);
            buttonList.Add(button);
            Debug.Log("Button added. I now have " + buttonList.Count + " deity buttons");

            //   var copy = Instantiate(itemTemplate);
            //   copy.transform.SetParent(content.transform, false);
            //   copy.transform.localPosition = Vector3.zero;

            //    GameObject newButton = buttonObjectPool.GetObject();
            //   newButton.transform.SetParent(contentPanel);

            //    CultButton button = newButton.GetComponent<CultButton>();
            //   button.Setup( cult, this );
        }
    }
}
