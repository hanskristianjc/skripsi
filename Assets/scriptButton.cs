using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scriptButton : MonoBehaviour {

	public Button tipe36;
	public Button tipe45;
	public Button tipe70;
	public Button kembali;
	public bool aktif = false;

	public void button36 () {
		if (aktif == false) {
			aktif = true;
			Application.LoadLevel("rumah36");
		}
	}
	public void button45(){
		Application.LoadLevel("rumah45");
	}

	public void button70(){
		Application.LoadLevel("rumah70");
	}

	public void button(){
		Application.LoadLevel("menuskin");
	}
}
