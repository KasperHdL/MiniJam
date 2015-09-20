using UnityEngine;
using System.Collections;

public class CandyManager : MonoBehaviour {
	int counter = 0;
	int timeToNewSpawn = 100;
	//load prefab of candy
	public GameObject prefab;
	
    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start() {
    	
	}

	void SpawnCandy(){
		for(int i = 0; i<5; i++){
        	Vector3 position = new Vector3(Random.Range(-40.0F, 40.0F), 0.56F, Random.Range(-40.0F, 40.0F));
        	Instantiate(prefab, position, Quaternion.identity);
    	}	
	}
	
	// Update is called once per frame
	void Update (){
		if(counter>timeToNewSpawn){
    		SpawnCandy();
    		counter = 0;
    	}
	counter++;
	}
}
