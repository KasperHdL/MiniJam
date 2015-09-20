using UnityEngine;
using System.Collections;

public class lollipop : MonoBehaviour {
	public Texture2D[] leadningColourTex = new Texture2D[4];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.up, (Mathf.PI / 230));

		Vector3 pos = transform.position;
		pos.y += Mathf.Cos (Time.realtimeSinceStartup * 2) / 80;
		transform.position = pos;
	}
}
