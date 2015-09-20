using UnityEngine;
using System.Collections;

public class MonsterSpawner : MonoBehaviour {


	public GameObject prefabMonster;
	public Transform containerMonster;

	public float spawnRange;
	public int numMonstersCur;
	public int numMonstersMax;

	public float spawnDelay;
	public float nextSpawn;



	// Use this for initialization
	void Start () {
		nextSpawn = Time.time + spawnDelay;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(numMonstersCur < numMonstersMax && nextSpawn < Time.time){
			SpawnMonster();

			numMonstersCur++;
			nextSpawn = Time.time + spawnDelay;
		}
	}

	public void MonsterDied(){
		numMonstersCur--;
	}

	private void SpawnMonster(){

		float a = Random.Range(0,2 * Mathf.PI);

		Vector3 spawnPos = new Vector3(spawnRange * Mathf.Cos(a), transform.position.y, spawnRange * Mathf.Sin(a));





		GameObject g = Instantiate(prefabMonster,spawnPos,Quaternion.identity) as GameObject;

		g.transform.SetParent(containerMonster,false);

		MonsterAI ai = g.GetComponent<MonsterAI>();
		ai.spawner = this;

	}
}
