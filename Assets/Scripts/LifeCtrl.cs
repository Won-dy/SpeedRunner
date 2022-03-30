using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCtrl : MonoBehaviour {
	public static int life;
	public float interval = 1f;
	private float time;

	void Start () {
		life = 3;
	}
	void Update () {
		Text uiText = GetComponent<Text>();
		uiText.text = "Life : " + life.ToString();
		if(life == 1)
		{
			time += Time.deltaTime;
			if (time >= interval)
			{
				time = 0f;
				SoundManager.instance.HeartSound();
			}
		}
		if (life == 0)
			Application.LoadLevel("Ending");
	}
}