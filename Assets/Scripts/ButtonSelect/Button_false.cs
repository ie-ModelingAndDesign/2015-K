using UnityEngine;
using System.Collections; 


public class  Button_false: MonoBehaviour {
	
	public void OnClick() {
		Debug.Log ("Button click!");

		gameObject.SetActive (false);
		
	}
	
}