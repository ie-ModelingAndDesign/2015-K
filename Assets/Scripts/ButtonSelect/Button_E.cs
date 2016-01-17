using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_E : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Click () {
		
		GameObject gameObjectB1 = this.transform.Find ("ButtonNW").gameObject;
		gameObjectB1.SetActive(false);
		GameObject gameObjectB2 = this.transform.Find ("ButtonN").gameObject;
		gameObjectB2.SetActive(false);
		GameObject gameObjectB3 = this.transform.Find ("ButtonNE").gameObject;
		gameObjectB3.SetActive(false);
		GameObject gameObjectB4 = this.transform.Find ("ButtonW").gameObject;
		gameObjectB4.SetActive(false);
		GameObject gameObjectB5 = this.transform.Find ("ButtonC").gameObject;
		gameObjectB5.SetActive(false);
		GameObject gameObjectB6 = this.transform.Find ("ButtonE").gameObject;
		gameObjectB6.SetActive(false);
		GameObject gameObjectB7 = this.transform.Find ("ButtonSW").gameObject;
		gameObjectB7.SetActive(false);
		GameObject gameObjectB8 = this.transform.Find ("ButtonS").gameObject;
		gameObjectB8.SetActive(false);
		GameObject gameObjectB9 = this.transform.Find ("ButtonSE").gameObject;
		gameObjectB9.SetActive(false);
		
		FlagManager.Instance.flags [7] = false;
		FlagManager.Instance.flags [107] = true;
	}
}
