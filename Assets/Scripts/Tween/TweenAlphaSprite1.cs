﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Unity2DのSpriteをフェードイン・アウトさせるTweener
/// </summary>
[AddComponentMenu ("WestHill/Tween/AlphaSprite")]
[RequireComponent (typeof(SpriteRenderer))]
public class TweenAlphaSprite1 : MonoBehaviour
{
	// 再生形式
	public enum PLAY_STYLE
	{
		// 1回のみ
		Once
	}
	
	/// <summary>
	/// フェード開始時のAlpha値(0〜1)
	/// </summary>
	public float fromAlpha = 1f;
	/// <summary>
	/// フェード終了時のAlpha値(0〜1)
	/// </summary>
	public float toAlpha = 0f;
	/// <summary>
	/// フェード時間
	/// </summary>
	public float duration = 2f;
	/// <summary>
	/// 開始までのディレイ
	/// </summary>
	public float startDelay =   76f;
	/// <summary>
	/// 再生形式
	/// </summary>
	public PLAY_STYLE playStyle = PLAY_STYLE.Once;  
	/// <summary>
	/// アニメーション終了後に通知を投げたいイベントレシーバー
	/// </summary>
	public GameObject eventReceiver;
	/// <summary>
	/// アニメーション終了後に投げる通知メソッド名
	/// </summary>
	public string callWhenFinished;
	// 起動と同時に再生するフラグ
	[SerializeField]
	bool playOnAwake ;
	// 自身のSpriteRenderer
	SpriteRenderer spriteRenderer;
	// 一時Color
	Color tempColor = Color.white;
	// Duration計測用
	float durationTimer;
	// ディレイ計測用
	float delayTimer;
	// 逆再生フラグ
	bool reverse;
	
	
	
	void Awake ()
	{
		if (playOnAwake) {
			Init ();
			Play ();

		} else {
			Stop ();
		}
	}
	
	void Update ()
	{
		if (spriteRenderer == null) {
			return;
		}
		
		// ディレイ
		if (0f < delayTimer) {
			delayTimer -= Time.deltaTime;
			return;
		}
		
		// TimeUpdate
		durationTimer -= Time.deltaTime;
		float nowTime = 1f - (durationTimer / duration);
		
		// Fade
		tempColor.a = reverse ? Mathf.Lerp (toAlpha, fromAlpha, nowTime) : Mathf.Lerp (fromAlpha, toAlpha, nowTime);
		spriteRenderer.color = tempColor;
		
		// Fade終了時
		float finishAlpha = reverse ? fromAlpha : toAlpha;
		if (tempColor.a == finishAlpha) {

			FlagManager.Instance.flags [111] = false;
			FlagManager.Instance.flags [112] = false;
			FlagManager.Instance.flags [113] = false;
			FlagManager.Instance.flags [114] = false;
			FlagManager.Instance.flags [115] = false;
			FlagManager.Instance.flags [116] = false;
			FlagManager.Instance.flags [100] = false;
			
			FlagManager.Instance.flags [9] = false;
			
			FlagManager.Instance.flags [8] = false;

			Application.LoadLevel ("Stage2");
			// 再生形式毎処理
			switch (playStyle) {
			case PLAY_STYLE.Once:
				// 通知設定がある場合は通知を投げる
				if (eventReceiver != null && !string.IsNullOrEmpty (callWhenFinished)) {

					FlagManager.Instance.flags [111] = false;
					FlagManager.Instance.flags [112] = false;
					FlagManager.Instance.flags [113] = false;
					FlagManager.Instance.flags [114] = false;
					FlagManager.Instance.flags [115] = false;
					FlagManager.Instance.flags [116] = false;
					FlagManager.Instance.flags [100] = false;
					
					FlagManager.Instance.flags [9] = false;
					
					FlagManager.Instance.flags [8] = false;

					Application.LoadLevel ("Stage2");
				}
				// 停止
				Stop ();
				break;
			
			}
		}
	}
	
	void OnEnable ()
	{
		Init ();
	}
	
	/// <summary>
	/// 初期化
	/// </summary>
	void Init ()
	{
		spriteRenderer = spriteRenderer == null ? GetComponent<SpriteRenderer> () : spriteRenderer;
		if (spriteRenderer == null) {
			return;
		}
		fromAlpha = Mathf.Clamp (fromAlpha, 0f, 1f);
		toAlpha = Mathf.Clamp (toAlpha, 0f, 1f);
		tempColor = spriteRenderer.color;
		tempColor.a = reverse ? toAlpha : fromAlpha;
		spriteRenderer.color = tempColor;
		durationTimer = duration;
		delayTimer = startDelay;
	}
	
	/// <summary>
	/// 再生開始
	/// </summary>
	public void Play ()
	{
		enabled = true;
	}
	
	/// <summary>
	/// 停止
	/// </summary>
	public void Stop ()
	{
		enabled = false;
	}
	
}
