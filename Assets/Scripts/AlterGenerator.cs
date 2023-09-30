using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlterGenerator : MonoBehaviour
{
    private string alterString;
    private int alter;
    public TextMeshProUGUI alterText;

    // Update is called once per frame
    public void GenAlter()
    {
        System.Random random = new System.Random();
        alter = random.Next(15, 80);
        alterString = "Alter: " + alter.ToString();
        alterText.text = alterString;
    }
}
