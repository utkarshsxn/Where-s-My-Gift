using System;
using UnityEngine;
public class lifeconcereteobserver:lifeObserverInterface{
	private int playerLives;
	public lifeconcereteobserver(){
		playerLives = 3;
	}
	public void updateLives(){
		playerLives--;
	}
	public int getPlayerLives(){
		return playerLives;
	}
}

