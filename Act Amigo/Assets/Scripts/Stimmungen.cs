using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stimmungen : MonoBehaviour
{
    [SerializeField] string[] stimmungsList;
    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;
    private string stimmung;
    public TextMeshProUGUI stimmungText;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            System.Random random = new System.Random();
            System.Random random2 = new System.Random();
            string stimmung = stimmungsList[random2.Next(0, stimmungsList.Length)];
            stimmungText.text = stimmung;
            int randomDauer = random.Next(28, 50);
            interpolationPeriod = randomDauer;
        }
    }
}
