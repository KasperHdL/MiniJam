using UnityEngine;
using System.Collections;

public class CandyBag : MonoBehaviour {
	float x;
	float y;
	float z;
	public float weight;
	//GUI
	public Font newFont;
	private int fontSize;
	public Texture2D Weight;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(0.5F+weight,1+weight,0.5F+weight);
	}

	void OnGUI(){
		GUIStyle nStyle = new GUIStyle ();
		nStyle.font = newFont;
		nStyle.fontSize = 20;
		nStyle.normal.textColor = new Color(255,102,100);
		GUI.DrawTexture(new Rect(Screen.width/2-200, 10, 100, 50), Weight);
		GUI.TextField (new Rect (Screen.width/2-50, 25, 300, 200), "" + weight, nStyle);
	}
}
