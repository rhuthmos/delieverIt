﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonInteractBack()
    {
        SceneManager.LoadScene("mainMenu");
        //StartCoroutine(JumpDur2());

    }
}
