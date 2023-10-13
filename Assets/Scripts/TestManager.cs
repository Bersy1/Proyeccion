using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    private extOSC.OSCTransmitter transmitter;
    private extOSC.OSCReceiver receiver;

    public static TestManager instance;

    // Start is called before the first frame update
    void Start()
    {
        if( instance != null)
        {
            Destroy(instance);
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
