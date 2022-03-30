using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour {
	void OnCollisionEnter(Collision target)
	{
		if (target.collider.CompareTag("Item"))
		{
			Debug.Log("Get");
			SoundManager.instance.GetSound();
			LifeCtrl.life++;
			Destroy(target.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
