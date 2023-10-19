using System.Collections;
using System.Collections.Generic;
using Fenderrio.ImageWarp;
using UnityEngine;

public class FondoManager : MonoBehaviour
{
    public GameObject imageWarpOBJ;
    ImageWarp imageWarpFondo, banderaAlta, banderaBaja, pinguino1, pinguino2;

    public Sprite fondo1, fondo2;

    private void Start()
    {
        imageWarpFondo = imageWarpOBJ.GetComponent<ImageWarp>();
    }

    //void FondoTest()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        imageWarp.sprite = fondo1;
    //    }
    //    else if (Input.GetKey(KeyCode.A))
    //    {
    //        imageWarp.sprite = fondo2;
    //    }
    //}

    public void FondoChanger(float x)
    {
        switch (x)
        {
            case 1:
                imageWarpFondo.sprite = fondo1;
                break;
            case 2:
                imageWarpFondo.sprite = fondo2;
                break;
        }
    }
}
