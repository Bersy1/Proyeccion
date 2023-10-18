using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartelManager : MonoBehaviour
{
    public TextMeshProUGUI cartelText;

    public string text1, text2, text3, text4, text5;

    public void ChangeCartelText(float x)
    {
        switch (x)
        {
            case 1:
                cartelText.text = text1;
                break;
            case 2:
                cartelText.text = text2;
                break;
            case 3:
                cartelText.text = text3;
                break;
            case 4:
                cartelText.text = text4;
                break;
            case 5:
                cartelText.text = text5;
                break;
        }
    }
}
