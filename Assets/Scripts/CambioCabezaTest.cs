using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCabezaTest : MonoBehaviour
{
    public GameObject cabeza1, cabeza2, cabeza3;

    public void CambioCabeza1()
    {
        cabeza1.SetActive(true);
        cabeza2.SetActive(false);
        cabeza3.SetActive(false);
    }

    public void CambioCabeza2()
    {
        cabeza1.SetActive(false);
        cabeza2.SetActive(true);
        cabeza3.SetActive(false);
    }
    public void CambioCabeza3()
    {
        cabeza1.SetActive(false);
        cabeza2.SetActive(false);
        cabeza3.SetActive(true);
    }
}
