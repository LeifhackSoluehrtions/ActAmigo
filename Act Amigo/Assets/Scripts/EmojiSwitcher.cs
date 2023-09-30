using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EmojiSwitcher : MonoBehaviour
{
    public MaxDauerGetter maxDauerGetter;
    public MinDauerGetter minDauerGetter;

    public Sprite emoji1;
    public Sprite emoji2;
    public Sprite emoji3;
    public Sprite emoji4;
    public Sprite emoji5;
    public Sprite emoji6;
    public Sprite emoji7;
    public Sprite emoji8;
    public Sprite emoji9;
    public Sprite emoji10;
    public Image emojiImage;

    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            System.Random random = new System.Random();
            int randomDauer = random.Next(minDauerGetter.minDauer, maxDauerGetter.maxDauer);
            System.Random random2 = new System.Random();
            int random2Nummer = random2.Next(1, 10);
            if (random2Nummer == 1)
            {
                emojiImage.sprite = emoji1;
            }
            if (random2Nummer == 2)
            {
                emojiImage.sprite = emoji2;
            }
            if (random2Nummer == 3)
            {
                emojiImage.sprite = emoji3;
            }
            if (random2Nummer == 4)
            {
                emojiImage.sprite = emoji4;
            }
            if (random2Nummer == 5)
            {
                emojiImage.sprite = emoji5;
            }
            if (random2Nummer == 6)
            {
                emojiImage.sprite = emoji6;
            }
            if (random2Nummer == 7)
            {
                emojiImage.sprite = emoji7;
            }
            if (random2Nummer == 8)
            {
                emojiImage.sprite = emoji8;
            }
            if (random2Nummer == 9)
            {
                emojiImage.sprite = emoji9;
            }
            if (random2Nummer == 10)
            {
                emojiImage.sprite = emoji10;
            }
            interpolationPeriod = randomDauer;
        }
    }
}
