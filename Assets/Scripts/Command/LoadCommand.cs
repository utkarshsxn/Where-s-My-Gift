using UnityEngine;
using System.Collections;

public class LoadCommand : CommandInterface{

	private Receiver theReceiver;

	public LoadCommand (Receiver receiver){
		theReceiver = receiver;
	}

	void CommandInterface.execute(){
		Debug.Log ("in con Load scene");
		theReceiver.LoadScene();
	}
}
