using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
	
	public float speed = 6.0f;
	public float rotateSpeed = 6.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
	
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	private int jumps;
	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection*Time.deltaTime);
	}
}
