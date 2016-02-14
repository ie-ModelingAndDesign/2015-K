using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text_Door2 : MonoBehaviour {
	
	public Text score;
	
	void Start () {
		FlagManager.Instance.flags [101] = false;
		FlagManager.Instance.flags [121] = false;
		FlagManager.Instance.flags [122] = false;
		FlagManager.Instance.flags [123] = false;
		FlagManager.Instance.flags [124] = false;
		FlagManager.Instance.flags [125] = false;
		FlagManager.Instance.flags [126] = false;
		FlagManager.Instance.flags [127] = false;
	}
	
	// 22文字まで(全角・句読点含む)
	
	void Update () {
		if (FlagManager.Instance.flags [10] == true)
		{
			Application.LoadLevel ("epiro-gu2");
		}
	}
}