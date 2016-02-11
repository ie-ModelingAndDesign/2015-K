using UnityEngine;
using System.Collections;

public class UG_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Click () {

		if (FlagManager.Instance.flags [6] == true) {
			Debug.Log ("mymt");
			FlagManager.Instance.flags [0] = true;
		}

	/*
		if (FlagManager.Instance.flags [25] == true) {
			Debug.Log ("moved");
			FlagManager.Instance.flags [0] = true;
	*/

		else
			FlagManager.Instance.flags [0] = false;
	}
}
