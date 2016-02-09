using UnityEngine;
using System.Collections;

public class InActivePicPic2 : MonoBehaviour {
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (FlagManager.Instance.flags [89] == true)
		{
			GameObject gameObjectPic = this.transform.Find ("Picture2").gameObject;
			gameObjectPic.SetActive(true);
		}
	}
}