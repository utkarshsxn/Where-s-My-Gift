using UnityEngine;
using System;

public class GiftFactory : MonoBehaviour{
	public GiftFactory(){
	}

	public GameObject getGift(GameObject destroyedBlock){

		String name = destroyedBlock.name;
		if (name.Contains ("Blue")) {
			return new BlueGiftScript().getGift();
		}

		else if (name.Contains ("Red")) {
			return new RedGiftScript().getGift();
		}

		else if (name.Contains ("Green")) {
			return new GreenGiftScript().getGift();
		}

		else if (name.Contains ("Yellow")) {
			return new YellowGift().getGift();
		}

		return null;
	}
}


