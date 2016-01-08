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
		
		FlagManager.Instance.flags [0] = true;
		Debug.Log ("hogeee");

	}

}
