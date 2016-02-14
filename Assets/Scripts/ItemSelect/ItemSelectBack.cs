using UnityEngine;
using System.Collections;

public class ItemSelectBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject gameObjectkey1 = this.transform.Find ("flamekey1").gameObject;
		GameObject gameObjectkey2 = this.transform.Find ("flamekey2").gameObject;
		GameObject gameObjectkey3 = this.transform.Find ("flamekey3").gameObject;
		GameObject gameObjectkey4 = this.transform.Find ("flamekey4").gameObject;
		GameObject gameObjectkami1 = this.transform.Find ("flamekami1").gameObject;
		GameObject gameObjectkami2 = this.transform.Find ("flamekami2").gameObject;
		GameObject gameObjectkami3 = this.transform.Find ("flamekami3").gameObject;
		GameObject gameObjectkami4 = this.transform.Find ("flamekami4").gameObject;
		GameObject gameObjectkami5 = this.transform.Find ("flamekami5").gameObject;
		GameObject gameObjectkami6 = this.transform.Find ("flamekami6").gameObject;
		GameObject gameObjectkami7 = this.transform.Find ("flamekami7").gameObject;
		GameObject gameObjectkami8 = this.transform.Find ("flamekami8").gameObject;

		if (FlagManager.Instance.flags [42] == true) {
			gameObjectkey1.SetActive(true);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}
		
		if (FlagManager.Instance.flags [43] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(true);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}
		
		if (FlagManager.Instance.flags [44] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(true);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [45] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(true);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [46] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(true);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [47] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(true);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [48] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(true);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [49] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(true);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [50] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(true);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}
	
		if (FlagManager.Instance.flags [51] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(true);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [52] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(true);
			gameObjectkami8.SetActive(false);
		}

		if (FlagManager.Instance.flags [53] == true) {
			gameObjectkey1.SetActive(false);
			gameObjectkey2.SetActive(false);
			gameObjectkey3.SetActive(false);
			gameObjectkey4.SetActive(false);
			gameObjectkami1.SetActive(false);
			gameObjectkami2.SetActive(false);
			gameObjectkami3.SetActive(false);
			gameObjectkami4.SetActive(false);
			gameObjectkami5.SetActive(false);
			gameObjectkami6.SetActive(false);
			gameObjectkami7.SetActive(false);
			gameObjectkami8.SetActive(true);
		}
	}
}
