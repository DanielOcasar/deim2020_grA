﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCustom : MonoBehaviour
{
    public float RotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat ("_Rotation", Time.time * RotateSpeed);
    }
}
