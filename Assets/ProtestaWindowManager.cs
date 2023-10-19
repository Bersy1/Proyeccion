using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProtestaWindowManager : MonoBehaviour
{
    public UnityEngine.UI.Image protesta;
    public GameObject protestaGO;

    private void Start()
    {
        protesta.color = new Color(protesta.color.r, protesta.color.g, protesta.color.b, 0f);
    }

    public void ProtestaActivator(float x)
    {
        switch (x)
        {
            case 1:
                protesta.color = new Color(protesta.color.r, protesta.color.g, protesta.color.b, 1f);
                //coloroe.a = Mathf.Lerp(0, 1, 5);
                break;
            case 2:
                protesta.color = new Color(protesta.color.r, protesta.color.g, protesta.color.b, 0f);
                //coloroe.a = Mathf.Lerp(1, 0, 5);
                break;

        }
    }
}
