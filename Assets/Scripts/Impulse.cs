using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Impulse : MonoBehaviour
{
    [SerializeField] string[] impulsList;
    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;
    private string impuls;
    public TextMeshProUGUI impulsText;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            System.Random random = new System.Random();
            System.Random random2 = new System.Random();
            string impuls = impulsList[random2.Next(0, impulsList.Length)];
            impulsText.text = impuls;
            int randomDauer = random.Next(16, 28);
            interpolationPeriod = randomDauer;
        }
    }
}
