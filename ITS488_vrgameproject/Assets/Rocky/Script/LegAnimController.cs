using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegAnimController : MonoBehaviour {

	public Animator legAnim;
	// Use this for initialization
	void Start () {
		legAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w"))
		{
			legAnim.Play("walk");
		}
	}
}
