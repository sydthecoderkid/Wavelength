﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoBattle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver(){
        if(Input.GetMouseButtonDown(0)){
            BeginCombat.combatbegun = true;
           SceneManager.LoadScene(CurrentScene.lastscene);
        }
    }
}
