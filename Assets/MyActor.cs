﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyActor : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    private float colorPower = 1f;
    [SerializeField]
    Slider sldColorPower;
    [SerializeField]
    Slider sldNormalAmount;
    [SerializeField]
    Slider sldRimPower;
    [SerializeField]
    Slider sldR;
    [SerializeField]
    Slider sldG;
    [SerializeField]
    Slider sldB;
    [SerializeField]
    Slider sldDivide;
    [SerializeField]
    Slider sldDivide2;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetFloat("_ColorPower", sldColorPower.value);
        render.material.SetFloat("_NormalAmount", sldNormalAmount.value);
        render.material.SetFloat("_RimPower", sldRimPower.value);
        render.material.SetFloat("_R", sldR.value);
        render.material.SetFloat("_G", sldG.value);
        render.material.SetFloat("_B", sldB.value);
        render.material.SetFloat("_Divide", sldDivide.value);
        render.material.SetFloat("_Divide2", sldDivide2.value);

    }
}
