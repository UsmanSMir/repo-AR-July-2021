using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class MakeSeeThrough : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.renderQueue = 3002; //set renderQueue to render after our Invisible mask(3001)
    }
}
