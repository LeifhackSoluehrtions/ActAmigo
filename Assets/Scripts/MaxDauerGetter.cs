using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MaxDauerGetter : MonoBehaviour
{
    public TMP_InputField maxDauerString;
    public int maxDauer = 2;

    // Update is called once per frame
    void Update()
    {
        maxDauer = int.Parse(maxDauerString.text);
    }
}
