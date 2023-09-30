using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KonfliktGenerator : MonoBehaviour
{
    [SerializeField] string[] konfliktList;
    public TextMeshProUGUI konfliktText;
    private string konflikt;

    public void GenKonflikt()
    {
        System.Random random = new System.Random();
        string konflikt = konfliktList[random.Next(0, konfliktList.Length)];
        konfliktText.text = konflikt;
    }
}
