﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	// do not touch -> false add!
	public void Click () {
		if (FlagManager.Instance.flags[5] == true)
			FlagManager.Instance.flags[0] = true;
		else
			FlagManager.Instance.flags[0] = false;
	}
}
