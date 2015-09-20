using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {

	//load sound of picking up candy
	public AudioClip pickUpCandySound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player1"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player1 weight
		}
		else if(other.gameObject.tag == "Player2"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player2 weight
		}
	}
}

