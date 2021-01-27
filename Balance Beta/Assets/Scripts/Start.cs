﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.F))
            Screen.fullScreen = !Screen.fullScreen;
            
        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("play");

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
    }
}
