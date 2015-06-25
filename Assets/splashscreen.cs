using UnityEngine;
using System.Collections;

public class splashscreen : MonoBehaviour {

	public bool Activated;
	public float DelayTime;
	public string NextScene;
	
	IEnumerator ExecuteSplashScreen(){
		if (Activated){
			yield return new WaitForSeconds(DelayTime);
			Application.LoadLevel(NextScene);
		}    
	}    
	
	// Use this for initialization
	void Start () {
		StartCoroutine(ExecuteSplashScreen());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}