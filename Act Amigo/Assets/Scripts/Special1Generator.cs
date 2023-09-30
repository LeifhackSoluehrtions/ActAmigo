using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Special1Generator : MonoBehaviour
{
    [SerializeField] string[] special1List;
    public TextMeshProUGUI special1Text;
    private string special1;

    public void GenSpecial1()
    {
        System.Random random = new System.Random();
        string special1 = special1List[random.Next(0, special1List.Length)];
        special1Text.text = special1;
    }
}
