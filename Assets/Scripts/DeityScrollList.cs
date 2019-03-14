using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeityScrollList : MonoBehaviour
{
    public List<Deity> deityList;
    private DeityList deityListScript;

    private ObjectManager objManagerScript;

    public DeityButton buttonToSpawn;

    public GameObject objManager;

    public GameObject content;

    // Start is called before the first frame update
    void Start()
    {
        //Get the deity oracle and add it to the list

        /*   GameObject oracle = GameObject.Find("DeityOracle");
           deityListScript = (DeityList)oracle.GetComponent(typeof(DeityList));
           deityList = deityListScript.GetDeityList();*/

        objManagerScript = (ObjectManager)objManager.GetComponent(typeof(ObjectManager));
        deityList = objManagerScript.GetDeityList();
        Debug.Log( deityList.Count );
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        AddButtons();
    }

    private void AddButtons()
    {
        for (int i = 0; i < deityList.Count; i++)
        {
            Deity deity = deityList[i];

            DeityButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup( deity , this);

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
