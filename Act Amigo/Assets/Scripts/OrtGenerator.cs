using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrtGenerator : MonoBehaviour
{
    [SerializeField] string[] ortList;
    public TextMeshProUGUI ortText;
    private string ort;

    public void GenOrt()
    {
        System.Random random = new System.Random();
        string ort = ortList[random.Next(0, ortList.Length)];
        ortText.text = ort;
    }
}
