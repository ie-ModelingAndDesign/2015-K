﻿using UnityEngine;
using System.Collections;

public class ItemActive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (FlagManager.Instance.flags [60] == true) {
			GameObject gameObject1 = this.transform.Find ("key1").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [61] == true) {
			GameObject gameObject1 = this.transform.Find ("kami1").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [62] == true) {
			GameObject gameObject1 = this.transform.Find ("kami2").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [63] == true) {
			GameObject gameObject1 = this.transform.Find ("key2").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [64] == true) {
			GameObject gameObject1 = this.transform.Find ("kami3").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [65] == true) {
			GameObject gameObject1 = this.transform.Find ("kami4").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [66] == true) {
			GameObject gameObject1 = this.transform.Find ("key3").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [67] == true) {
			GameObject gameObject1 = this.transform.Find ("kami5").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [68] == true) {
			GameObject gameObject1 = this.transform.Find ("kami6").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [69] == true) {
			GameObject gameObject1 = this.transform.Find ("key4").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [70] == true) {
			GameObject gameObject1 = this.transform.Find ("kami7").gameObject;
			gameObject1.SetActive(true);
		}

		if (FlagManager.Instance.flags [71] == true) {
			GameObject gameObject1 = this.transform.Find ("kami8").gameObject;
			gameObject1.SetActive(true);
		}

		//sonota tuika 61,62,...
	}
}
