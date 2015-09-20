using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
		public Font newFont;
		private int fontSize;
		private bool isGameDone = false;

	float timer = 120.0F;
	//gameObject CandyBag;
	public CandyBag cb;

	// Use this for initialization
	void Start () {
		cb = GameObject.Find ("CandyBag").GetComponent<CandyBag> ();

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer <= 0){
			timer = 0.0F;
			isGameDone = true;
			//Application.LoadLevel ("ScoreScene");

	}
		
		Debug.Log("Time:"+ timer);
		//Debug.Log("Winner: "+ cb.p);
	
	}
		void OnGUI(){
		GUIStyle nStyle = new GUIStyle ();
		nStyle.font = newFont;
		nStyle.fontSize = 18;
		if(isGameDone == true){
			//showing players score
		GUI.TextField (new Rect (50, 130, 300, 50), "Player 1: "+ cb.weightPlayer1,nStyle);
		GUI.TextField (new Rect (50, 230, 300, 50), "Player 2: "+ cb.weightPlayer2,nStyle);
		GUI.TextField (new Rect (50, 330, 300, 50), "Player 3: "+ cb.weightPlayer3,nStyle);
		GUI.TextField (new Rect (50, 330, 300, 50), "Player 4: "+ cb.weightPlayer4,nStyle);
	}
	//Showing Winner
		//nStyle.fontSize = 30;
		//GUI.TextField (new Rect (50, 130, 300, 50), "WINNER PLAYER NUMBER: "+ cb.p,nStyle);
		}

}
