using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;
	int maxGuesses = 10;

	public Text text;

	// Use this for initialization
	void Start ()
    {
        StartGame();

    }

    void StartGame()
    {
		max = 1000;
		min = 1;
		NextGuess ();
    }

    void NextGuess()
    {
		guess = Random.Range (min, max+1);
		text.text = guess.ToString();
		maxGuesses--;
		// if computer runs out of guesses, user wins.
		if (maxGuesses <= 0) 
		{
			SceneManager.LoadScene ("Win", LoadSceneMode.Single);
		}
    }


	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}

	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
}
