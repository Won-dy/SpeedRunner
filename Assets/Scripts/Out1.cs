using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out1 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Application.LoadLevel(Application.loadedLevel);
            Application.LoadLevel("Ending2");
        }
    }
}
