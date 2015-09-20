using UnityEngine;
using System.Collections;

public class CandyBag : MonoBehaviour {

	public float weightPlayer1;
	public float weightPlayer2;
	public float weightPlayer3;
	public float weightPlayer4;
	//GUI
	public Font newFont;
	private int fontSize;
	public Texture2D WeightPlayer1;
	public Texture2D WeightPlayer2;
	public Texture2D WeightPlayer3;
	public Texture2D WeightPlayer4;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.localScale = new Vector3(0.5F+weightPlayer1,1+weightPlayer1,0.5F+weightPlayer1);
	}

	public int GetWhoIsWinning() {
		float score = 0;
		int p = 0;

		if (weightPlayer1 > score) {
			score = weightPlayer1;
			p = 1;
		}
		if (weightPlayer2 > score) {
			score = weightPlayer2;
			p = 2;
		}
		if (weightPlayer3 > score) {
			score = weightPlayer3;
			p = 3;
		}
		if (weightPlayer4 > score) {
			score = weightPlayer4;
			p = 4;
		}

		return p;
	}

	void OnGUI(){
		GUIStyle nStyle = new GUIStyle ();
		nStyle.font = newFont;
		nStyle.fontSize = 50;
		nStyle.normal.textColor = new Color(255,102,100);
		GUI.DrawTexture(new Rect(Screen.width/3, Screen.height/3+100, 100, 50), WeightPlayer1); //one
		GUI.TextField (new Rect (Screen.width/3+110, Screen.height/3+100, 100, 50), "" + weightPlayer1, nStyle);
		GUI.DrawTexture(new Rect(Screen.width/2+150, Screen.height/3+100, 100, 50), WeightPlayer2); //two
		GUI.TextField (new Rect (Screen.width/2+150+110, Screen.height/3+100, 100, 50), "" + weightPlayer2, nStyle);
		GUI.DrawTexture(new Rect(Screen.width/2+150, Screen.height/3+150, 100, 50), WeightPlayer3); //three
		GUI.TextField (new Rect (Screen.width/2+150+110, Screen.height/3+150, 100, 50), "" + weightPlayer3, nStyle); 
		GUI.DrawTexture(new Rect(Screen.width/3, Screen.height/3+150, 100, 50), WeightPlayer4); //four
		GUI.TextField (new Rect (Screen.width/3+110, Screen.height/3+150, 100, 50), "" + weightPlayer4, nStyle); 
	}
}
