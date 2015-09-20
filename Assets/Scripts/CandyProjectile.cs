using UnityEngine;
using System.Collections;

public class CandyProjectile : MonoBehaviour {

	private float lifeTime = 2.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Destroy(gameObject, lifeTime);
	}
}
