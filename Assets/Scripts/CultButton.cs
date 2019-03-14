using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CultButton : MonoBehaviour
{
    public Button button;
    public Text cultName;
    public Text cultSize;
    public Image deityIcon;

    private Cult cult;
    private CultScrollList cultScrollList;

    public void Setup( Cult c, CultScrollList scrollList )
    {
        cult = c;
        cultName.text = cult.GetCultName();
        deityIcon = cult.GetDeityIcon();
        cultSize.text = cult.GetSize().ToString();

        cultScrollList = scrollList;

        button.onClick.AddListener(delegate { fillPanel(); });
    }

    public void fillPanel()
    {

    }
}
