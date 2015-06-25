using UnityEngine;
using System.Collections;

public class tipe : MonoBehaviour {
	public GUISkin MySkin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		float btnWidth = 250;
		float btnHeight = 70;
		float btnSpace = 80;
		int fontSize  = 30;
		float btnLeft = (Screen.width / 2) - 120;
		float btnTop = (Screen.height / 2);
		GUI.skin = MySkin;
		GUI.skin.button.fontSize =  GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
		
		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Tipe 36")){
			Application.LoadLevel("rumah36");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + btnSpace,btnWidth,btnHeight),"Tipe 45")){
			Application.LoadLevel("rumah45");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 2),btnWidth,btnHeight),"Tipe 70")){
			Application.LoadLevel("rumah70");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 3),btnWidth,btnHeight),"Kembali")){
			Application.LoadLevel("menuskin");
		}
	}
}
