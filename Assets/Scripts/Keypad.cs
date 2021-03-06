//Joshua Wisdom
//2313991
//CPSC 236-03
//jowisdom@chapman.edu
//Project 03: Keypad
//This is my own work, and I did not cheat on this assignment.

//No known errors.

//Completed alongside provided videos.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public KeypadBackground Background;

    private Combination combination;
    private List<int> buttonsEntered;

    // Start is called before the first frame update
    void Start()
    {
        combination = new Combination();
        ResetButtonEntries();
    }

    public void RegisterButtonClick(int buttonValue)
    {
        buttonsEntered.Add(buttonValue);
        print(String.Join(", ", buttonsEntered));
    }

    public void TryToUnlock()
    {

        if (IsCorrectCombination())
            Unlock();
        else
            FailToUnlock();

        ResetButtonEntries();
    }

    private bool IsCorrectCombination()
    {
        if (HaveNoButtonsBeenClicked())
            return false;

        if (HaveWrongNumberofButtonsBeenClicked())
            return false;

        return CheckCombination();
    }

    private bool HaveNoButtonsBeenClicked()
    {
        if (buttonsEntered.Count == 0)
            return true;
        return false;
    }

    private bool HaveWrongNumberofButtonsBeenClicked()
    {
        if (buttonsEntered.Count == combination.GetCombinationLength())
            return false;
        return true;
    }

    private bool CheckCombination()
    {
        // buttons entered:   1, 3, 5
        // combination:       1, 2, 3

        for (int buttonIndex = 0; buttonIndex < buttonsEntered.Count; buttonIndex++)
        {
            if (IsCorrectButton(buttonIndex) == false)
                return false;
        }

        return true;
    }

    private bool IsCorrectButton(int buttonIndex)
    {
        if (IsWrongEntry(buttonIndex))
            return false;
        return true;
    }

    private bool IsWrongEntry(int buttonIndex)
    {
        if (buttonsEntered[buttonIndex] == combination.GetCombinationDigit(buttonIndex))
            return false;
        return true;
    }

    private void Unlock()
    {
        print("Unlocked");
        Background.HideUnlockButton();
        Background.ChangeToSuccessColor();
    }

    private void FailToUnlock()
    {
        print("Wrong combination");
        Background.ChangeToFailedColor();
        StartCoroutine(ResetBackgroundColor());
    }

    private IEnumerator ResetBackgroundColor()
    {
        yield return new WaitForSeconds(.5f);
        Background.ChangeToDefaultColor();
    }

    private void ResetButtonEntries()
    {
        buttonsEntered = new List<int>();
    }

}