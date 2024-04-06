using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public TMP_Text lifesText;
    public GameObject gameOverWindow;
    public GameObject uIWindow;

    private int _score;
    private int _lifes;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        _score = 0;
        _lifes = 3;
    }

    public void UpdateScore()
    {
        _score += 10;
        scoreTxt.text = $"Score: {_score}";
    }

    public void UpdateLifes(int value)
    {
        _lifes += value;

        if (_lifes <= 0) 
        {
            GameOver();
        }
        else
        {
            lifesText.text = $"x {_lifes}";
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
        uIWindow.SetActive(false);
        gameOverWindow.SetActive(true);
    }
}
