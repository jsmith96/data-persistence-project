using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public InputField playerName;
    public Text highScore;

    void Start()
    {
        // Display Current High Score
        if (HighScoreManager.Instance.highScoreName != null)
        {
            highScore.text = $"{HighScoreManager.Instance.highScoreName}, {HighScoreManager.Instance.highScore} pts";
        }
        else
        {
            highScore.text = $"Nobody, {HighScoreManager.Instance.highScore} pts";
        }
        
    }

    public void NewPlayerName()
    {
        // Store New Player Name
        string name = playerName.text;
        HighScoreManager.Instance.currentName = name;
        Debug.Log($"Welcome {HighScoreManager.Instance.currentName}!");
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
