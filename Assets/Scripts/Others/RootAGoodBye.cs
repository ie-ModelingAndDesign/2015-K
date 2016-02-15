using UnityEngine;
using System.Collections;

public class RootAGoodBye : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (FlagManager.Instance.flags [5] == true)
		{
			gameObject.SetActive(false);
		}
	
	}
}
