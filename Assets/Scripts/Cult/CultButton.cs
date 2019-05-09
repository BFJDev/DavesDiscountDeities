using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CultButton : MonoBehaviour
{
    public Button button;
    public Text cultName;

    private Cult cult;
    private CultScrollList cultScrollList;

    public CultDetailsPanel DetailsPanel;

    public void Setup( Cult c, CultScrollList scrollList )
    {
        cult = c;
        cultName.text = cult.GetCultName();

        cultScrollList = scrollList;

        button.onClick.AddListener(delegate { fillPanel(); });
    }

    public void fillPanel()
    {
        DetailsPanel.populateDetailsPanel( cult );
    }
}
