using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public TMP_Text LifesText;

    private int _score;
    private int _lifes;

    // Start is called before the first frame update
    void Start()
    {
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
        LifesText.text = $"x {_lifes}";
    }
}
