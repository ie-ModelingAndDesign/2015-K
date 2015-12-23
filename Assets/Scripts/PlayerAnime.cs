using UnityEngine;
using System.Collections;

public class PlayerAnime : MonoBehaviour
{
	private Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	void Update ()
	{
		if (FlagManager.Instance.flags [3] == true)
		{
			anim.SetBool ("changeW", true);
		}

		else
		{
			anim.SetBool ("changeW", false);
		}
	}
}