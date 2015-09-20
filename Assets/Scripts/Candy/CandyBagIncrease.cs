using UnityEngine;
using System.Collections;

public class CandyBagIncrease : MonoBehaviour {
	//gameObject CandyBag;
	public CandyBag cb;

	// Use this for initialization
	void Start () {
		cb = GameObject.Find ("CandyBag").GetComponent<CandyBag> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(0.5F+cb.weightPlayer1,1+cb.weightPlayer1,0.5F+cb.weightPlayer1);
		transform.localScale = new Vector3(0.5F+cb.weightPlayer2,1+cb.weightPlayer2,0.5F+cb.weightPlayer2);
		transform.localScale = new Vector3(0.5F+cb.weightPlayer3,1+cb.weightPlayer3,0.5F+cb.weightPlayer3);
		transform.localScale = new Vector3(0.5F+cb.weightPlayer4,1+cb.weightPlayer4,0.5F+cb.weightPlayer4);
	}
}
