using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtestaManager : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource.volume = 0;
    }
    public void ChangeVolume(int x)
    {
        Debug.Log("inicia");
        float newVolume = ((float)x / 100);
        Debug.Log(newVolume);
        audioSource.volume = newVolume;
    }
}
