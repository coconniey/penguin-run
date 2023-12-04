using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAudio : MonoBehaviour
{
    public AudioSource audioSource;
    // Update is called once per frame
    void Play()
    {
        audioSource.Play();
    }
}
