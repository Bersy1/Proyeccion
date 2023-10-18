using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManiManager : MonoBehaviour
{
    public Image imagen;
    public Sprite mani1, mani2;

    public AudioSource bateria, bajo;
    public AudioClip bate1, bate2, bajo1, bajo2;
    
    public void ChangeMani(float x)
    {
        if (x == 1)
        {
            imagen.sprite = mani1;
            bateria.clip = bate1;
            bajo.clip = bajo1;
            bajo.Play();
            bateria.Play();
        }
        if (x == 2)
        {
            imagen.sprite = mani2;
            bateria.clip = bate2;
            bajo.clip = bajo2;
            bajo.Play();
            bateria.Play();
        }
    }
}
