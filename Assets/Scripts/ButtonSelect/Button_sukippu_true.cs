﻿using UnityEngine;
using System.Collections; 


public class  Button_sukippu_true: MonoBehaviour {
	
	public void OnClick() {
		Debug.Log ("Button click!");
		
		
		gameObject.SetActive (true);
		
	}
	
}