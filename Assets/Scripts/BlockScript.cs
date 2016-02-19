using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {
	public int hitsToKill;
	public int points;
	private int numberOfHits;
	public GameObject gift;
	private Vector3 getBlockPosition;
	private string getBlockName;
	
	// Use this for initialization
	void Start () {
		numberOfHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "ball"){
			numberOfHits++;
			
			if (numberOfHits == hitsToKill){
				// get reference of player object
				GameObject player = GameObject.FindGameObjectsWithTag("player")[0];
				getBlockPosition = transform.position;
				//Prints the position to the Console.
				getBlockName= this.gameObject.name;
				GiftFactory GiftFactory = new GiftFactory();
				GameObject g = GiftFactory.getGift(this.gameObject);
				GameObject gift = (GameObject)Instantiate(g, new Vector3(getBlockPosition.x, getBlockPosition.y, getBlockPosition.z), Quaternion.identity);
				player.SendMessage("addPoints", points);

				// destroy the object
				Destroy(this.gameObject);
			}
		}
	}
}