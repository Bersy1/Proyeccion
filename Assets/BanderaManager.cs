using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class BanderaManager : MonoBehaviour
{
    public GameObject banderaAlta;
    public GameObject banderaBaja;


    private void Start()
    {
        banderaAlta.SetActive(false);
        banderaBaja.SetActive(false);
    }

    public void BanderaActivator(float x)
    {
        switch (x)
        {
            case 1:
                banderaAlta.SetActive(true);
                banderaBaja.SetActive(false);
                break;
            case 2:
                banderaAlta.SetActive(false);
                banderaBaja.SetActive(true);
                break;
            case 3:
                banderaAlta.SetActive(true);
                banderaBaja.SetActive(true);
                break;
        }
    }
}

