using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour {

	SpriteRenderer MainSpriteRenderer;

	public Sprite HoldSprite;

	// Use this for initialization
	void Start ()
	{
		MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (FlagManager.Instance.flags [85] == true) {
			MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
			MainSpriteRenderer.sprite = HoldSprite;
		}
	}
}