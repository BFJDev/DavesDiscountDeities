using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CultScrollList : MonoBehaviour
{
    public List<Cult> cultList;

    public List<CultButton> buttonList;

    public CultButton buttonToSpawn;

    public ObjectManager objManager;

    public GameObject content;

    //public Transform contentPanel;
    //public CultScrollList otherList;
    //public SimpleObjectPool buttonObjectPool;

    // Start is called before the first frame update
    void Start()
    {
      //  cultList = new List<Cult>();
        //buttonList = new List<CultButton>();
        //string nm, WorshipMethod wmu, int s

     //   RefreshDisplay();
    }

    void OnEnable()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        RemoveButtons();
        RetrieveCultList();
        AddButtons();
    }

    private void RemoveButtons()
    {
        if (buttonList != null)
        {
            foreach (CultButton button in buttonList)
            {
                Destroy(button.gameObject);
            }

            buttonList.Clear();
        }

    }

    private void RetrieveCultList()
    {
        cultList = objManager.GetCultList();
        Debug.Log("Retrieved Cult List. New List has Size: " + cultList.Count);
    }

    private void AddButtons()
    {
        if( buttonList == null )
        {
            buttonList = new List<CultButton>();
        }
        for( int i = 0; i < cultList.Count; i++ )
        {
            Cult cult = cultList[i];

            CultButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup(cult, this);
            buttonList.Add(button);

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