using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignMainScript : MonoBehaviour
{
    private KeyCode keyInput1 = KeyCode.W;
    private KeyCode keyInput2 = KeyCode.A;
    private KeyCode keyInput3 = KeyCode.S;
    private KeyCode keyInput4 = KeyCode.D;
    private Renderer thisRend;
    private void Start()
    {
        thisRend = gameObject.GetComponent<Renderer>();
    }
    private void Update()
    {
        ListenForInput();
    }
    private void ListenForInput()
    {
        if (Input.GetKeyDown(keyInput1))
        {
            Debug.Log(keyInput1.ToString() + " has been pressed");
            thisRend.material.color = Color.red;
        }
        if (Input.GetKeyDown(keyInput2))
        {
            Debug.Log(keyInput2.ToString() + " has been pressed");
            thisRend.material.color = Color.green;
        }
        if (Input.GetKeyDown(keyInput3))
        {
            Debug.Log(keyInput3.ToString() + " has been pressed");
            thisRend.material.color = Color.blue;
        }
        if (Input.GetKeyDown(keyInput4))
        {
            Debug.Log(keyInput4.ToString() + " has been pressed");
            thisRend.material.color = Color.magenta;
        }
    }
}