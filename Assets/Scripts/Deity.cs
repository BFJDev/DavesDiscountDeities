﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public enum WorshipMethod { Idol, Ritual, Pilgrimage, Festival };

[System.Serializable]
public class Deity
{
    public Image deityIcon;
    public string GodName;
    public float worshipAmtRequired;
    public WorshipMethod preferredWorshipMethod;

    public float worshipAmtReceived = 0f;
    public float satisfaction;
    private List<Cult> worshippingCults;


    public Deity( string gName, WorshipMethod wm, int wam )
    {
        GodName = gName;
        preferredWorshipMethod = wm;
        worshipAmtRequired = wam;
        satisfaction = 60;
        worshippingCults = new List<Cult>();
    }

    public string GetName()
    {
        return GodName;
    }

    public WorshipMethod GetWorshipMethod()
    {
        return preferredWorshipMethod;
    }

    public float GetWorshipRequired()
    {
        return worshipAmtRequired;
    }

    public void SetWorshipReceived( float f )
    {
        worshipAmtReceived = f;
    }

    public float GetWorshipReceived()
    {
        return worshipAmtReceived;
    }

    public float GetSatisfaction()
    {
        return satisfaction;
    }

    public Image GetDeityIcon()
    {
        return deityIcon;
    }

    public void addCult( Cult c )
    {
        Debug.Log("Status #4: " + c.GetLeaderName());
        if( worshippingCults == null )
        {
            worshippingCults = new List<Cult>();
        }
        worshippingCults.Add(c);

        CalculateWorshipReceived();
    }

    public bool removeCult( Cult c )
    {
       return worshippingCults.Remove(c);
    }

    public List<Cult> GetWorshippingCults()
    {
        if (worshippingCults == null)
        {
            worshippingCults = new List<Cult>();
        }
        return worshippingCults;
    }

    private void CalculateWorshipReceived()
    {
        worshipAmtReceived = 0f;

        foreach (Cult cult in worshippingCults)
        {
            if ( cult.GetWorshipMethod() == preferredWorshipMethod)
            {
                //   Debug.Log(currentDeity.GetWorshipReceived() + (((float)currentCustomer.GetSize()) * currentCustomer.GetFaith()));
                worshipAmtReceived += (((float)cult.GetSize()) * cult.GetFaith());
            }
            else
                worshipAmtReceived += (((float)cult.GetSize()) * cult.GetFaith() * 0.7f);
        }

       
    }

/*
 * 
 * 
    public void DailyUpdate()
    {
        int dailyWorship = 0;

        foreach( Cult cult in worshippingCults )
        {
            if (cult.GetWorshipMethod() == preferredWorshipMethod)
                dailyWorship += (int)( ((float)cult.GetSize())*cult.GetFaith() );
            else
                dailyWorship += (int)( ((float)cult.GetSize()) * cult.GetFaith() * 0.7 );
        }

        if( dailyWorship >= worshipAmtRequired )
        {
            satisfaction += 10;
        }
        else
        {
            satisfaction -= 15;
        }

    }*/
}
