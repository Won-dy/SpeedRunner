using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchBomb : MonoBehaviour {

	void OnCollisionEnter(Collision target)
    {
        if (target.collider.CompareTag("Bomb"))
        {
			Debug.Log("Check");
			SoundManager.instance.ExplosionSound();
			LifeCtrl.life--;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
