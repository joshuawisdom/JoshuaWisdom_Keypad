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

public class KeypadButton : MonoBehaviour
{
    public int ButtonValue;
    public Keypad Keypad;

    public void OnClick()
    {
        Keypad.RegisterButtonClick(ButtonValue);
    }
}
