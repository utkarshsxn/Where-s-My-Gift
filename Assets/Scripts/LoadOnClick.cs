using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour,Receiver {

	public GameObject loadingImage;
	
	void OnStart(){
	}

	public void LoadScene(){
		Debug.Log ("Load scene");
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Debug.Log ("in quit game");
		Application .Quit ();
	}
}

