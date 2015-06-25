using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptPopUp : MonoBehaviour {
	public Canvas namaCanvas;
	public Canvas hargaCanvas;
	public bool tampil = false;
	public GUISkin MySkin;
	

	// Use this for initialization
	public void tampilPopUp () {
		if (tampil == false) {
			tampil = true;
			namaCanvas.enabled = true;

		}else if (tampil == true)
		{
			tampil = false;
			namaCanvas.enabled = false;
		}
	}

	public void tampilPopUpharga () {
		if (tampil == false) {
			tampil = true;
			hargaCanvas.enabled = true;
			
		}else if (tampil == true)
		{
			tampil = false;
			hargaCanvas.enabled = false;
		}
	}

	void OnGUI(){
				float btnWidth = 200;
		float btnHeight = 45;
		float btnSpace = 50;
		float btnLeft = 0;
		float btnTop = 0;//300;
		GUI.skin = MySkin;
		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Spesifikasi")){
			tampilPopUp();
			hargaCanvas.enabled = false;

		}
		if (GUI.Button(new Rect(btnLeft,btnTop + btnSpace,btnWidth,btnHeight),"KPR")){
			tampilPopUpharga();
			namaCanvas.enabled = false;
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + btnSpace *2,btnWidth,btnHeight),"Telp")){
			Application.OpenURL("tel://083833753660");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop + (btnSpace * 3),btnWidth,btnHeight),"Kembali")){
			Application.LoadLevel("menuskin");
		}
	}
}
