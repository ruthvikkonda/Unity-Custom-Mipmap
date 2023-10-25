using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMipLevel : MonoBehaviour
{
    void Start() {}

    void Update()
    {
        GetComponent<Renderer>().material.SetFloat("_MipLevel", 1.0f);
    }
}