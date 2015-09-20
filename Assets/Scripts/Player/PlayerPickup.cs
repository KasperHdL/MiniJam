using UnityEngine;
using System.Collections;

public class PlayerPickup : MonoBehaviour {

	public string controllerName;
	bool hasPickup;

	public GameObject prefabStun;
	public float stunBombForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(hasPickup && Input.GetButtonDown(controllerName + "Fire2")){
			
				ThrowStun();
				hasPickup = false;
		}
	}


	public void ThrowStun(){
		GameObject g = Instantiate(prefabStun,transform.position +(transform.forward*2),Quaternion.identity) as GameObject;
		
		g.GetComponent<Rigidbody>().AddForce(transform.forward * stunBombForce);

	}

	public void SetPickup(){
		hasPickup = true;
	}

}

