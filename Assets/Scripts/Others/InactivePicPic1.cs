using UnityEngine;
using System.Collections;

public class InactivePicPic1 : MonoBehaviour {
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (FlagManager.Instance.flags [89] == true)
			gameObject.SetActive (false);
	}
}