using UnityEngine;
using System.Collections;

public class Inactive : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.SetActive(false);

	}

	// Update is called once per frame
	void Update () {

		if (FlagManager.Instance.flags [7] == false)
		{
			GameObject gameObjectA = this.transform.Find ("TextKey1").gameObject;
			GameObject gameObjectB = this.transform.Find ("TextKey2").gameObject;
			GameObject gameObjectC = this.transform.Find ("TextKey3").gameObject;
			GameObject gameObjectD = this.transform.Find ("TextKey4").gameObject;
			GameObject gameObject1 = this.transform.Find ("TextKami1").gameObject;
			GameObject gameObject2 = this.transform.Find ("TextKami2").gameObject;
			GameObject gameObject3 = this.transform.Find ("TextKami3").gameObject;
			GameObject gameObject4 = this.transform.Find ("TextKami4").gameObject;
			GameObject gameObject5 = this.transform.Find ("TextKami5").gameObject;
			GameObject gameObject6 = this.transform.Find ("TextKami6").gameObject;
			GameObject gameObject7 = this.transform.Find ("TextKami7").gameObject;
			GameObject gameObject8 = this.transform.Find ("TextKami8").gameObject;
			gameObjectA.SetActive(false);
			gameObjectB.SetActive(false);
			gameObjectC.SetActive(false);
			gameObjectD.SetActive(false);
			gameObject1.SetActive(false);
			gameObject2.SetActive(false);
			gameObject3.SetActive(false);
			gameObject4.SetActive(false);
			gameObject5.SetActive(false);
			gameObject6.SetActive(false);
			gameObject7.SetActive(false);
			gameObject8.SetActive(false);
		}

	}

	public void Click () {
		gameObject.SetActive(false);
		FlagManager.Instance.flags [7] = false;
	}
}