using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
	// 移動速度
	public float speed = 3;
	
	void Update ()
	{
		// 移動方向(左右)
		float x = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		
		// 移動方向(上下)
		float y = CrossPlatformInputManager.GetAxisRaw ("Vertical");
		
		// 移動方向を求める
		Vector2 direction = new Vector2 (x, y).normalized;
		//Vector2 direction = new Vector2 (x, y);

		// 移動方向と速度の代入
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}