using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {


	public static Transform[] PLAYERS;

	// Use this for initialization
	void Awake () {
		PLAYERS = new Transform[transform.childCount];

		int i = 0; 	

		foreach(Transform child in transform){
			PLAYERS[i++] = child;
		}
	}
}
