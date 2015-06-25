using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scriptPopUpHarga : MonoBehaviour {
	public Canvas namaCanvas;
	public bool tampil = false;

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

}
