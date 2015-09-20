using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {

	//load sound of picking up candy
	//public AudioClip pickUpCandySound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		Debug.Log("Collision");
		//play sound
		//AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
		//destroy
		gameObject.SetActive (false);
	}
}

