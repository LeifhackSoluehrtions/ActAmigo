using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Special2Generator : MonoBehaviour
{
    [SerializeField] string[] special2List;
    public TextMeshProUGUI special2Text;
    private string special2;

    public void GenSpecial2()
    {
        System.Random random = new System.Random();
        string special2 = special2List[random.Next(0, special2List.Length)];
        special2Text.text = special2;
    }
}
