using UnityEngine;
using System.Collections;

public class lollipop : MonoBehaviour {
	public Texture2D[] leadningColourTex = new Texture2D[4];

	private CandyBag candyManager;

	// Use this for initialization
	void Start () {
		candyManager = GameObject.Find ("CandyBag").GetComponent<CandyBag> ();

		if (candyManager == null) {
			Debug.LogWarning("No Candy Manager found for Lollipop!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		// Update texture
		if (candyManager != null) {
			GetComponent<MeshRenderer>().material.SetTexture("_MainTex", leadningColourTex[candyManager.GetWhoIsWinning() - 1]);
		}

		// Rotate around
		transform.RotateAround(Vector3.up, (Mathf.PI / 230));

		Vector3 pos = transform.position;
		pos.y += Mathf.Cos (Time.realtimeSinceStartup * 2) / 80;
		transform.position = pos;
	}
}
