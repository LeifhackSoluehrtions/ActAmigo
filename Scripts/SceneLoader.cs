using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string mode1SceneName;
    [SerializeField] string impulsSceneName;
    [SerializeField] string stimmungSceneName;
    [SerializeField] string emojiSceneName;

    public void Mode1ButtonClick()
    {
        SceneManager.LoadScene(mode1SceneName);
    }

    public void ImpulseButtonClick()
    {
        SceneManager.LoadScene(impulsSceneName);
    }

    public void StimmungenButtonClick()
    {
        SceneManager.LoadScene(stimmungSceneName);
    }

    public void EmojiButtonClick()
    {
        SceneManager.LoadScene(emojiSceneName);
    }
}
