using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;
    public Button[] levelButtons;
    public int unlockLevel;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        if(levelButtons.Length > 0)
        {
            for(int i = 0; i < levelButtons.Length; i++)
            {
                levelButtons[i].interactable = false;
            }

            for(int i = 0; i < PlayerPrefs.GetInt("unlockLeves", 1); i++)
            {
                levelButtons[i].interactable = true;
            }
        }
    }

    public void AumentarNiveles()
    {
        if(unlockLevel > PlayerPrefs.GetInt("unlockLeves", 1))
        {
            PlayerPrefs.SetInt("unlockLeves", unlockLevel);
        }
    }
}
