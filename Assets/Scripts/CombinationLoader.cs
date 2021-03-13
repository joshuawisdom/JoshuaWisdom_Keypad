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
using System.IO;
using UnityEngine;

public static class CombinationLoader
{
    private static string combinationFolderName = "Assets/Text";
    private static string combinationFileName = "combination.txt";
    private static string combinationPath
    {
        get
        {
            return Path.Combine(combinationFolderName, combinationFileName);
        }
    }

    public static List<int> Load(List<int> defaultCombination)
    {
        EnsureFileExists(defaultCombination);
        return ReadCombinationFromFile();
    }

    private static void EnsureFileExists(List<int> defaultCombination)
    {
        if (!File.Exists("Assets/Text/combination.txt"))
            CreateFile(defaultCombination);
    }

    private static void CreateFile(List<int> defaultCombination)
    {
        EnsureDirectoryExists();

        StreamWriter writer = new StreamWriter("Assets/Text/combination.txt");
        foreach (int combinationEntry in defaultCombination)
        {
            writer.WriteLine(combinationEntry);
        }
        writer.Close();
    }

    private static void EnsureDirectoryExists()
    {
        if (!Directory.Exists(combinationFolderName))
            Directory.CreateDirectory(combinationFolderName);
    }

    private static List<int> ReadCombinationFromFile()
    {
        List<int> combination = new List<int>();

        StreamReader reader = new StreamReader("Assets/Text/combination.txt");
        string combinationNumber = string.Empty;
        while ((combinationNumber = reader.ReadLine()) != null)
        {
            int combinationInteger = int.Parse(combinationNumber);
            combination.Add(combinationInteger);
        }
        reader.Close();

        return combination;
    }

}
