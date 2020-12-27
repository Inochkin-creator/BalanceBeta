﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public TextMeshPro THS, CHS, SHS, TGP, CGP, SGP, Reset;
    
    void Start()
    {
        THS.text = "Total high score: " + PlayerPrefs.GetInt("TotalHighScore");
        CHS.text = "Cube high score: " + PlayerPrefs.GetInt("CubeHighScore"); 
        SHS.text = "Sphere high score: " + PlayerPrefs.GetInt("SphereHighScore"); 
        TGP.text = "Total games played: " + PlayerPrefs.GetFloat("TotalGamesPlayed");
        CGP.text = "On cube games played: " + PlayerPrefs.GetFloat("CubeGamesPlayed");
        SGP.text = "On sphere games played: " + PlayerPrefs.GetFloat("SphereGamesPlayed"); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
                if (hit.transform.name == "Reset")
                {
                    PlayerPrefs.DeleteAll();
                    SceneManager.LoadScene("Statistics");
                }
        }

        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("Menu");

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("scene1");
        
    }

    public void OnMouseOver()
    {  
        Reset.color = new Color(200, 0, 0);
    }
 
    public void OnMouseExit()
    {    
        Reset.color = new Color(255, 255, 255);
    }
}