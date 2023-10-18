using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class DesactivarGizmos : MonoBehaviour
{
    public List<GameObject> gizmos;

    private bool alternar = true;


    private void Update()
    {
        TeclaGizmos();
    }



    private void TeclaGizmos()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            AlternarGizmos();
        }

    }

    private void AlternarGizmos()
    {

        alternar = !alternar;

        foreach (var gizmo in gizmos)
        {
            gizmo.SetActive(alternar);
            
        }


    }



}