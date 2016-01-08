using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UG_wall_goal_text: MonoBehaviour {


	public Text score;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (FlagManager.Instance.flags [22] == true) {


			FlagManager.Instance.flags [101] = true;
			score.text = "おや？\n壁になにかかかっているようだ\n部屋にもってかえろう";


			if (FlagManager.Instance.flags [0] == true) {

				score.text = "";

				FlagManager.Instance.flags [0] = false;
				FlagManager.Instance.flags [22] = false;
				FlagManager.Instance.flags [101] = false;
				Application.LoadLevel ("Stage");


			}
		}
	
	}
}
