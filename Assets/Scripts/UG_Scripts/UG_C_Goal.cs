﻿using UnityEngine;
using System.Collections;

public class UG_C_Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D (Collider2D collider) {
		
		Debug.Log ("collision True_Root");
		FlagManager.Instance.flags [6] = true; //sessyoku
		
		if (FlagManager.Instance.flags [0] == true)
		{
			FlagManager.Instance.flags [0] = false;
			FlagManager.Instance.flags [8] = true;
			FlagManager.Instance.flags [23] = true;
		}
	}
	
	void OnTriggerExit2D (Collider2D collider) {
		FlagManager.Instance.flags [6] = false;
	}
}