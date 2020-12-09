﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundManager : MonoBehaviour
{
    public Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = GetScreenBounds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;
        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }
}
