﻿using UnityEngine;
using System.Collections;

public class op_Button_emptystage : MonoBehaviour {
	
	public void OnClick()
	{
		FlagManager.Instance.flags [111] = false;
		FlagManager.Instance.flags [112] = false;
		FlagManager.Instance.flags [113] = false;
		FlagManager.Instance.flags [114] = false;
		FlagManager.Instance.flags [115] = false;
		FlagManager.Instance.flags [116] = false;
		FlagManager.Instance.flags [100] = false;
		
		FlagManager.Instance.flags [9] = false;
		
		FlagManager.Instance.flags [8] = false;

		FlagManager.Instance.flags [6] = false;

		Application.LoadLevel ("Stage2");
		
	}
}
