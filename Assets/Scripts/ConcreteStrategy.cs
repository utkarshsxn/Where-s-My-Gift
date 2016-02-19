using System;
using UnityEngine;

public class defaultStrategy : Strategy{
	private bool size_set=false;

	public void execute(GameObject g){
	
		Debug.Log ("default starategy");

		//stop rotation
		g.transform.Rotate (new Vector3(0,0, 0));
		//reset size
		g.transform.localScale = new Vector2 (0.25f, 0.25f);

		//resize the collider
		if (!size_set) {
			CircleCollider2D c = g.GetComponent<CircleCollider2D> ();
			c.radius = g.GetComponent<SpriteRenderer> ().bounds.size.magnitude;
			size_set=true;
		}
	}

	public defaultStrategy (){
		Debug.Log ("default strategy new");
	}
}

public class secondStrategy : Strategy
{
	private static Vector2 MaxSize= new Vector2(0.5f,0.5f) ;

	float height =50.2f;
	float speed =2.0f;
	float timimgOffset=0.0f;
	private bool size_set=false;

	public void execute(GameObject g){

		//BallScript.setStrategy (new SmallerBall());

		Debug.Log ("sec starategy");
		Vector2 MaxSize= new Vector2(0.5f,0.5f) ;
		float offset = Mathf.Sin(Time.deltaTime * 2 ) * height ;

		//reposition by applying forces along sinwave
		Vector2 b =g.GetComponent<Rigidbody2D>().velocity.normalized;
		g.GetComponent<Rigidbody2D> ().AddForce(new Vector2 ( b.x , b.y)+ new Vector2(offset ,0.0f));

	}

	public secondStrategy (){
	}
}

public class BiggerBall : Strategy {

	private static Vector2 MaxSize= new Vector2(0.5f,0.5f) ;
	private bool size_set=false;

	public void execute(GameObject g){

		//resize the collider
		if (!size_set && (g.transform.localScale.magnitude < MaxSize.magnitude))  {
			
			//increase size
			g.transform.localScale = (Vector2)g.transform.localScale + new Vector2 (0.1f, 0.1f);

			CircleCollider2D c = g.GetComponent<CircleCollider2D> ();
			c.radius = g.GetComponent<SpriteRenderer> ().bounds.size.magnitude;
			size_set=true;
		}
	}

	public BiggerBall(){
	}

}

public class SmallerBall : Strategy {
	private static Vector2 MaxSize= new Vector2(0.5f,0.5f) ;
	private bool size_set=false;

	public void execute(GameObject g){

		//resize the collider
		if (!size_set && (g.transform.localScale.magnitude < MaxSize.magnitude))  {
			
			//increase size
			g.transform.localScale = (Vector2)g.transform.localScale - new Vector2 (0.1f, 0.1f);

			CircleCollider2D c = g.GetComponent<CircleCollider2D> ();
			c.radius = g.GetComponent<SpriteRenderer> ().bounds.size.magnitude;
			size_set=true;
		}
	}
}


