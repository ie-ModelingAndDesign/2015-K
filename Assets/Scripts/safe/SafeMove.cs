using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SafeMove : MonoBehaviour {
	
	public Text score;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Click () {

		score.text = "";

		GameObject gameObjectPlayer1 = this.transform.Find ("PlayerNormal").gameObject;
		GameObject gameObjectPlayer2 = this.transform.Find ("PlayerNaki").gameObject;
		GameObject gameObjectPlayer3 = this.transform.Find ("PlayerOdoroki").gameObject;
		GameObject gameObjectPlayer4 = this.transform.Find ("PlayerKyohu").gameObject;
		GameObject gameObjectPlayer5 = this.transform.Find ("PlayerWarai").gameObject;
		
		gameObjectPlayer1.SetActive(true);
		gameObjectPlayer2.SetActive(false);
		gameObjectPlayer3.SetActive(false);
		gameObjectPlayer4.SetActive(false);
		gameObjectPlayer5.SetActive(false);

		FlagManager.Instance.flags [9] = false;

		FlagManager.Instance.flags [8] = false;
		FlagManager.Instance.flags [18] = false;
		FlagManager.Instance.flags [106] = false;
	}
}
