using UnityEngine;
using System.Collections;

public class UG_wall_start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D (Collision2D collision) {


		Debug.Log ("collision wall");
		Application.LoadLevel ("Stage");

	}
}
