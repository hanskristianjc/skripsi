using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GUISkin MySkin;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		float btnWidth = 200;
		float btnHeight = 45;
		float btnSpace = 50;
		float btnLeft = 0;
			float btnTop = 0;//300;
		GUI.skin = MySkin;
		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Spesifikasi")){
		
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + btnSpace,btnWidth,btnHeight),"KPR")){

		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 2),btnWidth,btnHeight),"Back")){
			Application.Quit();
		}
	}    
}
