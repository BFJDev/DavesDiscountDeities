using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public List<GameObject> TutorialSlides;

    int curIdx = 0;

    GameObject currentSlide;

    // Start is called before the first frame update
    void Start()
    {
        //TutorialSlides = new List<GameObject>();
        TutorialSlides[curIdx].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void progress()
    {
        curIdx++;
        if (curIdx < TutorialSlides.Count)
            TutorialSlides[curIdx].SetActive(true);
        Debug.Log("PROGRESS! curIdx = " + curIdx);
        TutorialSlides[curIdx - 1].SetActive(false);
        
    }
}
