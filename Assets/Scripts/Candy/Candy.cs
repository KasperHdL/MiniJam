using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {

	//load sound of picking up candy
	public AudioClip pickUpCandySound;
	//gameObject CandyBag;
	public CandyBag cb;

	// Use this for initialization
	void Start () {
		cb = GameObject.Find ("CandyBag").GetComponent<CandyBag> ();
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player1"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player1 weight
			cb.weightPlayer1+=0.1F;
		}
		else if(other.gameObject.tag == "Player2"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player2 weight
			cb.weightPlayer2+=0.1F;
		}
		else if(other.gameObject.tag == "Player3"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player3 weight
			cb.weightPlayer3+=0.1F;
		}
		else if(other.gameObject.tag == "Player4"){
			//play sound
			AudioSource.PlayClipAtPoint(pickUpCandySound, transform.position);
			//destroy
			gameObject.SetActive (false);
			//increase player4 weight
			cb.weightPlayer4+=0.1F;
		}
	}
}

