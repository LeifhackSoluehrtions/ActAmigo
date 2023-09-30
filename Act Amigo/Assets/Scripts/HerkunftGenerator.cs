using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HerkunftGenerator : MonoBehaviour
{
    [SerializeField] string[] herkunftList;
    public TextMeshProUGUI herkunftText;
    private string herkunft;

    public void GenHerkunft()
    {
        System.Random random = new System.Random();
        string herkunft = herkunftList[random.Next(0, herkunftList.Length)];
        herkunftText.text = "Herkunft: " + herkunft;
    }
}
