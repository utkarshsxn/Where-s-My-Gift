using UnityEngine;
using System.Collections;

public class QuitCommand : CommandInterface{
	
	private Receiver theReceiver;
	
	public QuitCommand  (Receiver receiver){
		theReceiver = receiver;
	}
	
	void CommandInterface.execute(){
		Debug.Log ("in )conc quit comand");
		theReceiver.QuitGame();
	}
}