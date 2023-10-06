using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCuerpoTest : MonoBehaviour
{
    public GameObject cuerpo1, cuerpo2, cuerpo3;

    public void CambioCuerpo1()
    {
        cuerpo1.SetActive(true);
        cuerpo2.SetActive(false);
        cuerpo3.SetActive(false);
    }
    public void CambioCuerpo2()
    {
        cuerpo1.SetActive(false);
        cuerpo2.SetActive(true);
        cuerpo3.SetActive(false);
    }
    public void CambioCuerpo3()
    {
        cuerpo1.SetActive(false);
        cuerpo2.SetActive(false);
        cuerpo3.SetActive(true);
    }
}
