using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour {

	public Image splashImage;
	public string loadLeval;

	// Use this for initialization
	// 
	IEnumerator Start () {
	
		splashImage.canvasRenderer.SetAlpha(0.0f);

		fadeIn();
		yield return new WaitForSeconds(2.5f);
		fadeOut();
		yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene(loadLeval);       
      
	}
	void fadeIn(){
		splashImage.CrossFadeAlpha(1.0f,1.5f,false);
	}
	void fadeOut(){
		splashImage.CrossFadeAlpha(0.0f,2.5f,false);
	}

}
