using UnityEngine;
using System.Collections;

public class GreenGiftScript : MonoBehaviour,Gifts {
	string name = "greengift";
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag =="player"){
			Debug.Log ("delete green gift"); 
			BallScript.setStrategy(new secondStrategy());
			Destroy (this.gameObject);
		}
	}

	public GameObject getGift(){
		return (GameObject)Resources.Load(this.name);
	}
}
