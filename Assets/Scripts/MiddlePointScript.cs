using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePointScript : MonoBehaviour
{
    public GameObject leftTop;
    //public GameObject leftBot;
    public GameObject rightTop;
    //public GameObject rightBot;

    private Vector3 topValues;
    //private Vector3 botValues;

    void Update()
    {
        SetValues();
        StitchTogether();
    }

    private void StitchTogether()
    {
        leftTop.transform.localPosition = topValues;
        //rightBot.transform.localPosition = botValues;
    }
    private void SetValues()
    {
        topValues = rightTop.transform.localPosition;
        //botValues = leftBot.transform.localPosition;
    }
}
