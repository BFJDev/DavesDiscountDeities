using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Cult
{
    public string leaderName;
    public string cultName;
    public WorshipMethod worshipMethodUsed;
    public Image deityIcon;
    public int size;
    public float faith;

    public Cult( string nm, WorshipMethod wmu, int s )
    {
        cultName = nm;
        worshipMethodUsed = wmu;
        size = s;
        faith = 1.0F;
    }

    public Cult( string ln, string nm, WorshipMethod wmu, int s )
    {
        leaderName = ln;
        cultName = nm;
        worshipMethodUsed = wmu;
        size = s;
        faith = 1.0F;
    }

    public string GetLeaderName()
    {
        return leaderName;
    }

    public WorshipMethod GetWorshipMethod()
    {
        return worshipMethodUsed;
    }

    public string GetCultName()
    {
        return cultName;
    }

   public int GetSize()
    {
        return size;
    }

   public float GetFaith()
    {
        return faith;
    }

    public Image GetDeityIcon()
    {
        return deityIcon;
    }


}
