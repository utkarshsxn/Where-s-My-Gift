using UnityEngine;
using System.Collections;

public class ConcreteInvoker : Invoker {

	private CommandInterface load;
	private CommandInterface quit;

	public ConcreteInvoker(CommandInterface l,CommandInterface q){
	
		load = l;
		quit = q;
	}

	public void gameQuit(){
		Debug.Log ("in )conc invoker.quit");
		quit.execute ();
	}
	public void gameLoad(){
		Debug.Log ("in )conc invoker.gameload");
		load.execute ();
	}


}
