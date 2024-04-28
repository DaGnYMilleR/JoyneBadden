using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Buttontorestart : MonoBehaviour
{
    private shall1 _1shall;
    private shall2 _2shall;
    private shall3 _3shall;

    private Vector3[] defaultPos;

    private void Start()
    {
        _1shall = FindObjectOfType<shall1>();
        _2shall = FindObjectOfType<shall2>();
        _3shall = FindObjectOfType<shall3>();
    }

    public void ResetTo()
    {
        _1shall.ResetToDefault();
        _2shall.ResetToDefault();
        _3shall.ResetToDefault();
    }
}
