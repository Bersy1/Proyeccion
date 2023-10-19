using System.Collections;
using System.Collections.Generic;
using Fenderrio.ImageWarp;
using UnityEngine;

public class FondoManager : MonoBehaviour
{
    public GameObject imageWarpOBJ;
    ImageWarp imageWarp;

    public Sprite fondo1;
    public Sprite fondo2;

    private void Start()
    {
        imageWarp = imageWarpOBJ.GetComponent<ImageWarp>();
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
                imageWarp.sprite = fondo1;
                break;
            case 2:
                imageWarp.sprite = fondo2;
                break;
        }

    }
}
