using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource clip;

    public void PlaySoundButton()
    {
        clip.Play();
    }
}
