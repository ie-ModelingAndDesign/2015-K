using UnityEngine;
using System.Collections;

public class op_Button_tostage : MonoBehaviour {


	public void OnClick() {
		Debug.Log("Button click!");
		Application.LoadLevel ("Stage");

	}
}
