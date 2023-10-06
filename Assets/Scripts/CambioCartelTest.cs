using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCartelTest : MonoBehaviour
{
    public Material material1, material2, material3, materialBase;
    public GameObject cartel;

    private void Start()
    {
        materialBase = cartel.GetComponent<MeshRenderer>().material;
    }
    public void CambioMat1()
    {
        cartel.GetComponent<MeshRenderer>().material = material1;
    }
    public void CambioMat2()
    {
        cartel.GetComponent<MeshRenderer>().material = material2;
    }
    public void CambioMat3()
    {
        cartel.GetComponent<MeshRenderer>().material = material3;
    }
}
