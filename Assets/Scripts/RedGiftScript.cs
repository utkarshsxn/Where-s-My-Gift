using UnityEngine;
using System.Collections;

public class RedGiftScript : MonoBehaviour,Gifts {
	string name = "redgift";
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag =="player"){
			Debug.Log ("Delete Red gift");  
			BallScript.setStrategy(new BiggerBall());
			Destroy (this.gameObject);
		}
	}

	public GameObject getGift(){
		return (GameObject)Resources.Load(this.name);
	}
}
