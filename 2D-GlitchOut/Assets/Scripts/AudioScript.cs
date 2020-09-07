using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource audioPlay;

    private float musicVolume = 1f;

    void Start()
    {
        audioPlay = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioPlay.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
