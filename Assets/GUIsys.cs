using UnityEngine;
using System.Collections;

public class GUIsys : MonoBehaviour {
	public GUIStyle Tombol1;

	public float x = 0;
	public float y = 0;

	public float lebar = 100f;
	public float tinggi = 30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGui (){
		GUI.Button (new Rect (x, y, lebar, tinggi), "Tombol1");

	}
}
