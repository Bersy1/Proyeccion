using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using extOSC;

public class InputWindow : MonoBehaviour
{
    public bool showed;
    public GameObject window;
    public TMP_InputField ipText;
    public OSCTransmitter transmitter;
    public OSCReceiver receiver;

    private void Awake()
    {
        Hide();
        showed = false;
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
}
