using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCabezaTest : MonoBehaviour
{
    public GameObject cabeza1, cabeza2, cabeza3;
    public float stateInt;

    private void Update()
    {
        if (true)
        {
            switch (stateInt)
            {
                case 1:
                    CambioCabeza1();
                    break;
                case 2:
                    CambioCabeza2();
                    break;
                case 3:
                    CambioCabeza3();
                    break;
            }
        }
    }
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

    public void setValueInt(float x)
    {
        stateInt = x;
    }
}
