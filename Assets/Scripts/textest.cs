using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textest : MonoBehaviour {

	public Text score;

	void Start () {	
	}

	void Update () {
		if (FlagManager.Instance.flags [10] == true) {
			score.text = "bed";
			FlagManager.Instance.flags [0] = false;
			FlagManager.Instance.flags [10] = false;
		}
	}
}