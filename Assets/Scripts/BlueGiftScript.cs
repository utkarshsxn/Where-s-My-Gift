using UnityEngine;
using System.Collections;

public class BlueGiftScript : MonoBehaviour, Gifts {
	string name = "bluegift";
	void OnTriggerEnter2D(Collider2D other){

		//Debug.Log ("blue gift deleted");  
		if (other.gameObject.tag =="player"){
			BallScript.setStrategy(new defaultStrategy());
			//BallScript.setStrategy(new BiggerBall());
			Debug.Log ("blue gift deleted");  
			Destroy (this.gameObject);
		}
	}

	public GameObject getGift(){
		return (GameObject)Resources.Load(this.name);
	}
}
