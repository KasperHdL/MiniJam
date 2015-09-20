using UnityEngine;
using System.Collections;

public class CandyManager : MonoBehaviour {

	//load prefab of candy
	public GameObject prefab;
	//weight 
	int weight = 0;
	
    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start() {
    	SpawnCandy();
	}

	void SpawnCandy()
	{
		for(int i = 0; i<5; i++){
        	Vector3 position = new Vector3(Random.Range(-5.0F, 5.0F), 0.56F, Random.Range(-5.0F, 5.0F));
        	Instantiate(prefab, position, Quaternion.identity);
    	}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
