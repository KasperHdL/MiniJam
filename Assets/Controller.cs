using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public string controllerNumber;
	private float speed = 6.0F;
	private float jumpSpeed = 8.0F;
	private float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {


		//Horizontal and Vertical movement (forward, backward, strafe left & right)
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis(controllerNumber + "Horizontal"), 0, Input.GetAxis(controllerNumber + "Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			//Jumping
			if (Input.GetButton(controllerNumber + "Jump"))
				moveDirection.y = jumpSpeed;
			}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);


	}
}
