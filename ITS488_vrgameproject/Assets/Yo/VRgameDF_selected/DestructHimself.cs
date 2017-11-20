using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructHimself : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Kills the game object in 2 seconds after loading the object
        Destroy(gameObject, 2);
	}
}
