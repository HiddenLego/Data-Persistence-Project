using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI nameInput;

    public void StartGame()
    {
        SplitManager.Instance.playerName = nameInput.text;

        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        SplitManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
