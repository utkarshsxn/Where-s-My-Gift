using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	public float playerVelocity;
	private Vector3 playerPosition;
	public float boundary;
	public AudioClip pointSound;  
	public AudioClip lifeSound;
	public ScoreObserver scoreKeeper;
	public lifeconcereteobserver lifeMaintain;

	// Use this for initialization
	void Start () {
		// get the initial position of the game object
		playerPosition = gameObject.transform.position;
		scoreKeeper = new ScoreObserver ();
		lifeMaintain = new lifeconcereteobserver (); 
	}

	// Update is called once per frame
	void Update () {
		// horizontal movement
		playerPosition.x += Input.GetAxis ("Horizontal") * playerVelocity ;

		// update the game object transform
		transform.position = playerPosition;

		// boundaries
		if (playerPosition.x < -boundary) {
			transform.position = new Vector3 (-boundary, playerPosition.y, playerPosition.z);
		} 
		if (playerPosition.x > boundary) {
			transform.position = new Vector3(boundary, playerPosition.y, playerPosition.z);     
		}

		// Check game state
		WinLose ();
	}
	void addPoints(int points){
		//playerPoints += points;
		scoreKeeper.updatePoints (points);
		GetComponent<AudioSource>().PlayOneShot (pointSound);
	}

	public void OnGUI(){
		int lives = lifeMaintain.getPlayerLives ();
		int points = scoreKeeper.getPlayerPoints ();
		GUI.Label (new Rect(5.0f,3.0f,200.0f,200.0f),"Live's: " + lives + "  Score: " + points);
	}


	void TakeLife(){
		lifeMaintain.updateLives ();
		GetComponent<AudioSource>().PlayOneShot (lifeSound);
	}


	void WinLose(){
		// restart the game
		int lives = lifeMaintain.getPlayerLives ();
		if (lives == 0) {
			Application.LoadLevel("Level1");        
		}
		// blocks destroyed
		if ( ((GameObject.FindGameObjectsWithTag ("block")).Length == 0) && lives > 0 ) {
			 //check the current level
			if (Application.loadedLevelName == "Level1") {
				Application.LoadLevel("Level2");
			} else {
				Application.Quit();
			}
		}
	}
}