using UnityEngine;
using System.Collections;

public class CandyBag3Increase : MonoBehaviour {

	//gameObject CandyBag;
	public CandyBag cb;

	// Use this for initialization
	void Start () {
		cb = GameObject.Find ("CandyBag").GetComponent<CandyBag> ();
	
	}
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(GameObject.FindGameObjectWithTag("Player3").transform.position.x,GameObject.FindGameObjectWithTag("Player3").transform.position.y, GameObject.FindGameObjectWithTag("Player3").transform.position.z);
		transform.localScale = new Vector3((0.5F+cb.weightPlayer3)/15,(1+cb.weightPlayer3)/15,(0.5F+cb.weightPlayer3)/15);
	}
}
