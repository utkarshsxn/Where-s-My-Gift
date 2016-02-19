using UnityEngine;
using System.Collections;

public class YellowGift : MonoBehaviour,Gifts {
	string name = "yellowgift";
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag =="player"){
			Debug.Log ("yellow gift deleted"); 
			BallScript.setStrategy(new SmallerBall());
			Destroy (this.gameObject);
		}
	}

	public GameObject getGift(){
		return (GameObject)Resources.Load(this.name);
	}
}
