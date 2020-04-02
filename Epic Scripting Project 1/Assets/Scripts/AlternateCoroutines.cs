﻿using System.Collections;
using System.Collections;
using UnityEngine;
public class AlternateCorourtine : MonoBehaviour
{
    private WaitForFixedUpdate waitObj;
    public bool canRun = true;
    
    void Start()
    {
        waitObj = new WaitForFixedUpdate();
        StartCoroutine(OnStartCoroutine());
    }
    public IEnumerator OnStartCoroutine()
    {
        while (canRun)
        {
            yield return waitObj;
            print("Repeating");
        }
    }
}