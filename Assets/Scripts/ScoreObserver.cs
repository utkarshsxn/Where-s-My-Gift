using System;
using UnityEngine;

public interface IScoreObserver{
	void updatePoints(int points);
}

public class ScoreObserver :MonoBehaviour, IScoreObserver{
	PlayerScript player = new PlayerScript();
	private int playerPoints;

	public ScoreObserver(){
		playerPoints = 0;
	}

	public void updatePoints(int points){
		playerPoints = playerPoints + points;
	}

	public int getPlayerPoints(){
		return playerPoints;
	}
}


