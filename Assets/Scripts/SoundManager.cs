using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip soundExplosion, soundGet, soundHeart;
	AudioSource myAudio;
	public static SoundManager instance;
	void Awake()
	{
		if (SoundManager.instance == null)
			SoundManager.instance = this;
	}
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}
	public void ExplosionSound()
	{
		myAudio.PlayOneShot(soundExplosion);
	}
	public void GetSound()
	{
		myAudio.PlayOneShot(soundGet);
	}
	public void HeartSound()
	{
		myAudio.PlayOneShot(soundHeart);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
