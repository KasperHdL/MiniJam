using UnityEngine;
using System.Collections;

public class PlayerPickup : MonoBehaviour {


	Type currentPickup;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(currentPickup != Type.None && Input.GetButtonDown(controllerName + "Fire2")){

		}
	}


	public void SetPickup(PlayerPickup.Type pickup){
		currentPickup = pickup;
	}

	public enum Type{
		None,
		Stun
	}

}

