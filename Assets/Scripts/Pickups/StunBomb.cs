using UnityEngine;
using System.Collections;

public class StunBomb : MonoBehaviour {


	public float blowTime;
	public float blowDelay;
	public float blowLength;



	public bool blowingUp = false;

	public Collider coll;

	// Use this for initialization
	void Start () {
		blowTime = Time.time + blowDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if(blowingUp){
			if(blowTime < Time.time){
				Destroy(gameObject);
			}
		}else if(blowTime < Time.time){
			//BLOW UP!
			coll.isTrigger = true;
			GetComponent<Rigidbody>().useGravity = false;
			transform.localScale = new Vector3(10,10,10);
			blowTime = Time.time + blowLength;
			blowingUp = true;
		}
	}

	void OnTriggerEnter(Collider other){
		if(blowingUp){
			if(other.gameObject.layer == 9){
				other.gameObject.GetComponent<Controller>().Stun(3f);
			}

			if(other.gameObject.tag == "Monster"){
				other.gameObject.GetComponent<MonsterAI>().Stun(5f);
			}
		}
	}
}
