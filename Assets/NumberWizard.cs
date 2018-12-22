using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization

		int min;
		int max;
		int guess;
		int maxGuessesAllowed = 100;
		public Text text;

	void Start () {
		StartGame();
	}
	void StartGame(){
		min = 1;
		max = 1000;
		//guess = Random.Range(min, max+1);
		//text.text=guess.ToString();
		NextGuess();
	}

	void NextGuess(){
		guess = Random.Range(min, max+1);
		text.text ="";
		text.text =guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if ( maxGuessesAllowed==0 ){
			Application.LoadLevel("Win");
		}
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
}
