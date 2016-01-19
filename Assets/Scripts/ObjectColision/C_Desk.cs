using UnityEngine;
using System.Collections;

public class C_Desk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionStay2D (Collision2D collision) {
		
		Debug.Log ("collision desk");
		FlagManager.Instance.flags [6] = true; //sessyoku
		
		if (FlagManager.Instance.flags [0] == true) {
			FlagManager.Instance.flags [0] = false;
			FlagManager.Instance.flags [8] = true;
			FlagManager.Instance.flags [16] = true;
		}
	}
	
	void OnCollisionExit2D (Collision2D collision) {
		FlagManager.Instance.flags [6] = false;
	}
}
