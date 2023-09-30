using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinDauerGetter : MonoBehaviour
{
    public TMP_InputField minDauerString;
    public int minDauer = 1;

    // Update is called once per frame
    void Update()
    {
        minDauer = int.Parse(minDauerString.text);
    }
}
