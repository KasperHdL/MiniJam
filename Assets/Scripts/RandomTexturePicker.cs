using UnityEngine;
using System.Collections;

public class RandomTexturePicker : MonoBehaviour {
	public Texture2D[] possibleTextures;

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer> ().material.SetTexture ("_MainTex", possibleTextures[ (int)Random.Range(0, possibleTextures.Length) ]);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
