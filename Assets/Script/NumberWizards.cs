using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start ()
    {
        StartGame();

    }

    void StartGame()
    {
		max = 1000;
		min = 1;
		guess = 500;

		print("============================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than 500?");
        print("Up = higher, Down = lower, Return = equal");

		max = max++;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Up = higher, Down = lower, Return = " + guess);
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow key is pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow is pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won");
			StartGame();
        }
	}
}
