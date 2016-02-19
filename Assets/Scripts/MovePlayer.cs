using UnityEngine;
public class MovePlayer : MonoBehaviour {
	
	public KeyCode moveLeft ;
	public KeyCode moveRight ;
	public float speed = 10.0f;
	
	
	// Update is called once per frame
	void Update () {
		print("updt");
		if (Input.GetKey (moveLeft)) {
			GetComponent<Rigidbody2D>().velocity.Set( speed * -1,0);
		} 
		else if (Input.GetKey (moveRight)) {
			
			GetComponent<Rigidbody2D>().velocity.Set (speed,0) ;
		} 
		else {
			
			GetComponent<Rigidbody2D>().velocity.Set (0,0) ;
		}
		
	}
}

