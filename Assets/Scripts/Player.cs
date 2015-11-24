using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
	// 移動スピード
	public float speed = 3;
	
	void Update ()
	{
		// 右・左
		float x = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		
		// 上・下
		float y = CrossPlatformInputManager.GetAxisRaw ("Vertical");
		
		// 移動する向きを求める
		Vector2 direction = new Vector2 (x, y).normalized;
		//Vector2 direction = new Vector2 (x, y);

		// 移動する向きとスピードを代入する
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}