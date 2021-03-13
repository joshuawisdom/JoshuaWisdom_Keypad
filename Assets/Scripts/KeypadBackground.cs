//Joshua Wisdom
//2313991
//CPSC 236-03
//jowisdom@chapman.edu
//Project 03: Keypad
//This is my own work, and I did not cheat on this assignment.

//No known errors.

//Completed alongside provided videos.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadBackground : MonoBehaviour
{
    public GameObject UnlockButton;
    public Image BackgroundImage;

    public void HideUnlockButton()
    {
        UnlockButton.SetActive(false);
    }

    public void ChangeToSuccessColor()
    {
        BackgroundImage.color = new Color32(0,150,108,200);
    }

    public void ChangeToFailedColor()
    {
        BackgroundImage.color = new Color32(170, 0, 25, 200);
    }

    public void ChangeToDefaultColor()
    {
        BackgroundImage.color = new Color32(219, 219, 219, 200);
    }
}
