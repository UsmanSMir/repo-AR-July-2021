using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Xrayable : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.renderQueue = 3002;
    }
}
