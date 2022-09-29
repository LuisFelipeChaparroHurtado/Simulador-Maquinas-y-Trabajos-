using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceNo2CheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name) {
			case "Side_No2_1":
				DiceNumberTextScript.diceNumber2 = 6;
				break;
			case "Side_No2_2":
				DiceNumberTextScript.diceNumber2 = 5;
				break;
			case "Side_No2_3":
				DiceNumberTextScript.diceNumber2 = 4;
				break;
			case "Side_No2_4":
				DiceNumberTextScript.diceNumber2 = 3;
				break;
			case "Side_No2_5":
				DiceNumberTextScript.diceNumber2 = 2;
				break;
			case "Side_No2_6":
				DiceNumberTextScript.diceNumber2 = 1;
				break;
			}
		}
	}
}
