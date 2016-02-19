using UnityEngine;
using System;
using System.Collections.Generic;
public class Menu: MonoBehaviour {
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
		//quit game if escape key is pressed
		if (Input.GetKey(KeyCode.Escape)) 
		{ 
			Application.LoadLevel(0);
		}
	}

public void OnClick(){
	Debug.Log("in gmeload" + isQuit);
	isQuit =true;
	i.gameLoad();
	}
}



