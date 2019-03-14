using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CultScrollList : MonoBehaviour
{
    public List<Cult> cultList;

    public CultButton buttonToSpawn;

    public GameObject content;

    //public Transform contentPanel;
    //public CultScrollList otherList;
    //public SimpleObjectPool buttonObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        cultList = new List<Cult>();
        //string nm, WorshipMethod wmu, int s

        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        AddButtons();
    }

    private void AddButtons()
    {
        for( int i = 0; i < cultList.Count; i++ )
        {
            Cult cult = cultList[i];

            CultButton button = Instantiate(buttonToSpawn);
            button.transform.SetParent(content.transform, false);
            button.transform.localPosition = Vector3.zero;
            button.Setup(cult, this);

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