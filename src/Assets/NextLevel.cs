﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other){
		int i = Application.loadedLevel;
		Application.LoadLevel (i + 1);
	}
}
