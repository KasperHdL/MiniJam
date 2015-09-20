using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;


public class MonsterAI : MonoBehaviour {

	public MonsterSpawner spawner;

	public AICharacterControl steering;


	public bool isChasing;


	public float chaseEngageDistance;
	public float chaseDisengageDistance;



	// Update is called once per frame
	void FixedUpdate () {

		if(isChasing){
			Vector3 delta = steering.target.position - transform.position;
			if(delta.magnitude >= chaseDisengageDistance){
				isChasing = false;
				steering.target = null;
			}
		}else{


			foreach(Transform player in PlayerHandler.PLAYERS){
				Vector3 delta = player.position - transform.position;

				if(delta.magnitude < chaseEngageDistance){
					//raycast to player, is he visible to monster

					if (! Physics.Linecast(transform.position, player.position,1<<8)) {

						isChasing = true;
						steering.target = player;
					}



				}
			}
			

			//check for nearby players
			//if players close enough then pursue
				//check if players are too far away if so stop chase

			
		}


	}
}