using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {

	public GameObject prefabPickup;

	public ParticleSystem particles;


	private Transform pickup;

	public float nextPickup;
	public float spawnDelay;
	
	// Update is called once per frame
	void Update () {
		if(pickup == null){
			if(nextPickup < Time.time){
				SpawnPickup();
				particles.Play();
				nextPickup = Time.time + spawnDelay;
			}
		}else{
			//rotate?
		}
	}

	private void SpawnPickup(){
		GameObject g = Instantiate(prefabPickup,Vector3.up * 2,Quaternion.identity) as GameObject;

		g.transform.SetParent(transform,false);
		pickup = g.transform;

	}

	void OnTriggerEnter(Collider other){

		if(pickup != null){
			Destroy(pickup.gameObject);
			particles.Play();
			nextPickup = Time.time + spawnDelay;
		}
	}
}
