﻿using UnityEngine;
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
		transform.localScale = new Vector3(0.5F+cb.weightPlayer3,1+cb.weightPlayer3,0.5F+cb.weightPlayer3);
	}
}
