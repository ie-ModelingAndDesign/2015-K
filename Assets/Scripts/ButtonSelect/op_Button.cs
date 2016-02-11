using UnityEngine;
using System.Collections; 


public class op_Button: MonoBehaviour {

	public void OnClick() {
		Debug.Log ("Button click!");


		//System.Threading.Thread.Sleep (2000);

		gameObject.SetActive (false);
		   
	}

}