using UnityEngine;
using System.Collections;

public class Cbed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionStay2D (Collision2D collision) {

		Debug.Log ("collision bed");
		FlagManager.Instance.flags [5] = true; //sessyoku

		if (FlagManager.Instance.flags [0] == true)
			FlagManager.Instance.flags [10] = true;
	}

	void OnCollisionExit2D (Collision2D collision) {
		Debug.Log ("collision bed exit");
		FlagManager.Instance.flags [5] = false;
	}
}