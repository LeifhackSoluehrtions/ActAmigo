using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    [SerializeField] string mainSceneName;
    public void BackButtonClick()
    {
        SceneManager.LoadScene(mainSceneName);
    }
}
