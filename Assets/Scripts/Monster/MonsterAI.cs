using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;


public class MonsterAI : MonoBehaviour {

	public MonsterSpawner spawner;

	public AICharacterControl steering;

	private int playerIndex;
	public CandyBag candybag;

	public bool isChasing;


	public float chaseEngageDistance;
	public float chaseDisengageDistance;

	public float attackDistance;


	private bool isStunned = false;
	private float stopBeingStunned;

	private float nextAttack;
	public float attackDelay;


	// Update is called once per frame
	void FixedUpdate () {
		if(isStunned){
			if(stopBeingStunned < Time.time)
				isStunned = false;
		}else if(isChasing){
			Vector3 delta = steering.target.position - transform.position;
			if(delta.magnitude >= chaseDisengageDistance){
				isChasing = false;
				steering.target = null;
				playerIndex = -1;
			}
			if(nextAttack < Time.time && delta.magnitude < attackDistance){
				switch(playerIndex){
					case 0:
						if(candybag.weightPlayer1 >= 1f)
							candybag.weightPlayer1 -= 1f;
						break;
					case 1:
						if(candybag.weightPlayer2 >= 1f)
							candybag.weightPlayer2 -= 1f;
						break;
					case 2:
						if(candybag.weightPlayer3 >= 1f)
							candybag.weightPlayer3 -= 1f;
						break;
					case 3:
						if(candybag.weightPlayer4 >= 1f)
							candybag.weightPlayer4 -= 1f;
						break;
				}

				
				nextAttack = Time.time + attackDelay;
			}
		}else{

			int i = 0;
			foreach(Transform player in PlayerHandler.PLAYERS){
				Vector3 delta = player.position - transform.position;

				if(delta.magnitude < chaseEngageDistance){
					//raycast to player, is he visible to monster

					if (! Physics.Linecast(transform.position, player.position,1<<8)) {
						
						isChasing = true;
						steering.target = player;
						playerIndex = i;

					}



				}
				i++;
			}
			

			//check for nearby players
			//if players close enough then pursue
				//check if players are too far away if so stop chase

			
		}


	}

	public void Stun(float time){
		stopBeingStunned = Time.time + time;
		isStunned = true;
		isChasing = false;
		steering.target = null;
	}
}