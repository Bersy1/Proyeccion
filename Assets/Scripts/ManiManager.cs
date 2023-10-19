using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManiManager : MonoBehaviour
{
    public Image imagen;
    public Sprite mani1, mani2, mani3, mani4, mani5;

    public AudioSource bateria, bajo, guitarra;
    public AudioClip bate1, bate2, bate3, bate4, bajo1, bajo2, bajo3, bajo4, guitarra1, guitarra2, guitarra3, guitarra4;

    public void ChangeMani(float x)
    {
        switch (x)
        {
            case 1:
                imagen.sprite = mani1;
                bateria.clip = bate1;
                bajo.clip = bajo1;
                guitarra.clip = guitarra1;
                bajo.Play();
                bateria.Play();
                guitarra.Play();
                break;
            case 2:
                imagen.sprite = mani2;
                bateria.clip = bate2;
                bajo.clip = bajo2;
                guitarra.clip = guitarra2;
                bajo.Play();
                bateria.Play();
                guitarra.Play();
                break;
            case 3:
                imagen.sprite = mani3;
                bateria.clip = bate3;
                bajo.clip = bajo3;
                guitarra.clip = guitarra3;
                bajo.Play();
                bateria.Play();
                guitarra.Play();
                break;
            case 4:
                imagen.sprite = mani4;
                bateria.clip = bate4;
                bajo.clip = bajo4;
                guitarra.clip = guitarra4;
                bajo.Play();
                bateria.Play();
                guitarra.Play();
                break;
            case 5:
                imagen.sprite = mani5;
                break;
        }
    }
}
