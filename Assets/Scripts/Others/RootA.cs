using UnityEngine;
using System.Collections;

public class RootA : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (FlagManager.Instance.flags [5] == true) {

			GameObject gameObject1 = this.transform.Find ("RootBack").gameObject;
			GameObject gameObject2 = this.transform.Find ("Root").gameObject;
			gameObject1.SetActive(true);
			gameObject2.SetActive(true);
		}
	
	}
}
