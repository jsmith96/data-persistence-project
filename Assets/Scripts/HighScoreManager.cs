using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance;

    public string currentName;

    public int highScore;
    public string highScoreName;


    private void Awake()
    {
        // prevent multiple instances of HighScoreManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        highScoreName = null;
        LoadHighScore();
    }

    public void SetHighScore(string player, int score)
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreName = player;
        }
    }

    public void SaveHighScore()
    {
        //
    }

    void LoadHighScore()
    {
        //
    }
}
