using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestAccelerometer : MonoBehaviour
{
    public TextMeshProUGUI numberInScreen;
    public float contador;
    public int intMaster;
    public float shakeDetectionThreshold, minShakeInterval, sqrShakeDetectionThreshold, timeSinceLastShake;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        sqrShakeDetectionThreshold = Mathf.Pow(shakeDetectionThreshold, 2);
    }

    // Update is called once per frame
    void Update()
    {
        ShowNumber();
        if(contador > 0)
        {
            contador -= Time.deltaTime;
        }
        if (contador > 100)
        {
            contador = 100;
        }
        if(contador < 0)
        {
            contador = 0;
        }

        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold && Time.unscaledTime >= timeSinceLastShake + minShakeInterval)
        {
            contador++;
            timeSinceLastShake = Time.unscaledTime;
        }
        if(Time.unscaledTime - timeSinceLastShake >= 5)
        {
            contador = 0;
        }
    }

    public void ShowNumber()
    {
        intMaster = Mathf.FloorToInt(contador);
        numberInScreen.text = intMaster.ToString();
    }
}
