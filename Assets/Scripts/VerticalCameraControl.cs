using UnityEngine;
using System.Collections;

public class VerticalCameraControl : MonoBehaviour {

	public string controllerNumber;
	private float turnSpeed = 80.0F;
	private Vector3 viewDirection = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Vertical control of camera
		transform.Rotate(Vector3.right, (Input.GetAxis(controllerNumber + "ViewY") * -1) * turnSpeed * Time.deltaTime, Space.Self);
	}
}
