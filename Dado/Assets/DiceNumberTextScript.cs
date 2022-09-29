using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour {

	Text text;
	
	public static int diceNumber;
	public static int diceNumber2;
	public static int total;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		total = (int) (diceNumber + diceNumber2);
		text.text = total.ToString();
	}
}
