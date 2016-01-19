using UnityEngine;
using System.Collections;

public class Inactive : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.SetActive(false);

	}

	// Update is called once per frame
	void Update () {

	}

	public void Click () {
		gameObject.SetActive(false);
		FlagManager.Instance.flags [7] = false;
	}
}