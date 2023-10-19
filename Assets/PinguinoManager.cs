using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinguinoManager : MonoBehaviour
{
    public GameObject pinguino1, pinguino2;

    private void Start()
    {
        pinguino1.SetActive(false);
        pinguino2.SetActive(false);
    }

    public void PinguinoActivator(float x)
    {
        switch (x)
        {
            case 1:
                pinguino1.SetActive(true);
                pinguino2.SetActive(false);
                break;
            case 2:
                pinguino1.SetActive(false);
                pinguino2.SetActive(true);
                break;
            case 3:
                pinguino1.SetActive(true);
                pinguino2.SetActive(true);
                break;
        }
    }
}
