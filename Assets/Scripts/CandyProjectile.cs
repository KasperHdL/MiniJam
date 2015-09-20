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

	void OnCollisionEnter (Collision col) {
		if(col.gameObject.tag == "Monster") { 
			col.gameObject.GetComponent<MonsterAI>().Stun(1.0f);
			Debug.Log("Hello");
		}

		Destroy (gameObject);
	}
}
