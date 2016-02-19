using UnityEngine;
using System;
using System.Collections.Generic;
public class Menu2: MonoBehaviour {
	Receiver g ;
	CommandInterface c;
	CommandInterface s;
	ConcreteInvoker i;
	public bool isQuit;
	
	public void Awake(){
		g = gameObject.AddComponent<LoadOnClick>();
		c = new QuitCommand(g);
		s = new LoadCommand(g);
		i= new ConcreteInvoker(s,c);
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape)) 
		{ 
			Application.LoadLevel(0);
		}
	}
	
	public void OnClick(){
		Debug.Log("on mouse" + isQuit);
		i.gameQuit();
	}
}



