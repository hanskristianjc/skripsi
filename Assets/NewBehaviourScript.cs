using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
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
		float btnTop = (Screen.height / 2) - 50;
		GUI.skin = MySkin;
		GUI.skin.button.fontSize =  GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;

		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Lihat Rumah")){
			Application.LoadLevel("rumah36");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + btnSpace,btnWidth,btnHeight),"Bantuan")){
			Application.LoadLevel("Bantuan");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 2),btnWidth,btnHeight),"Tentang Aplikasi")){
			Application.LoadLevel("Tentangaplikasi");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 3),btnWidth,btnHeight),"Denah")){
			Application.LoadLevel("Denah");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 4),btnWidth,btnHeight),"Keluar")){
			Application.Quit();
		}
	}
}
