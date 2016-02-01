using UnityEngine;
using System.Collections;

public class UG_wall : MonoBehaviour {

	public GameObject Player;
	private Vector3 StartPos;

	// Use this for initialization
	void Start () {

		Player = GameObject.Find("Player");
		StartPos = Player.gameObject.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionStay2D (Collision2D collision) {

		Debug.Log ("collision wall");
		FlagManager.Instance.flags [21] = true;
	//	FlagManager.Instance.flags [25] = true;

		Player.gameObject.transform.position = StartPos;
	}

}
