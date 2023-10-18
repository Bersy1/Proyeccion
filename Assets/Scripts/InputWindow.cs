using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using extOSC;

public class InputWindow : MonoBehaviour
{
    public bool showed;
    public GameObject window, shakeControl, maniquiControl, cartelControl, shakeManager;
    public TMP_InputField ipText;
    public OSCTransmitter transmitter;
    public OSCReceiver receiver;

    private void Awake()
    {
        Hide();
        showed = false;
        Control1();
    }
    public void ChangeState()
    {
        if(showed == true)
        {
            Hide();
        }
        else if(showed == false)
        {
            Show();
        }
    }
    public void Show()
    {
        window.SetActive(true);
        showed = true;
    }
    public void Hide()
    {
        window.SetActive(false);
        showed = false;
    }
    public void ChangeIp()
    {
        transmitter.RemoteHost = ipText.text;
        Debug.Log(ipText.text);
    }

    public void Control1()
    {
        shakeControl.SetActive(true);
        shakeManager.SetActive(true);
        maniquiControl.SetActive(false);
        cartelControl.SetActive(false);
    }

    public void Control2()
    {
        shakeControl.SetActive(false);
        shakeManager.SetActive(false);
        maniquiControl.SetActive(true);
        cartelControl.SetActive(false);
    }

    public void Control3()
    {
        shakeControl.SetActive(false);
        shakeManager.SetActive(false);
        maniquiControl.SetActive(false);
        cartelControl.SetActive(true);
    }
}
