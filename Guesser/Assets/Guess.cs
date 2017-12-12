using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guess : MonoBehaviour {
	
	public Text textbox;

	private int max = 100;
	private int min = 1;
	private int guess;

	 private int counter = 7;


	// Use this for initialization
	void Start ()
	{
		guess = Random.Range(min, max);


		textbox.text = "Welcome! This is Number Guesser!\new line test"
		+"\nPick a number in your head"
		+ "\n\nThe highest number you can pick is" + max
		+ "\nThe lowest number you can pick is" + min
		+ "\n\nIs the number higher or lower than" + guess
		+ "\nUp arrpw fpr higher, down for lower, enter for equal";
	







		print ("Welcome to the Number Guessing Simulator!");
		print ("pick a number in your head");

		print ("the highest number you can pick is "+max);
		print ("the lowest number you can pick is "+min);

		print ("is the number higher or lower than "+guess);
		print ("up arrow for higher, down for lower, enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (counter== -1) {
			
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				//counter--;
				textbox.text = "you win!";
			}

		}
		else if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			textbox.text = "Is the number higher or lower than" + guess;
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			textbox.text = "Is the number highter or lower than" + guess;
		}
		if (Input.GetKeyDown (KeyCode.Return))
		{
			textbox.text = "I win!";
		}

		if (counter == 0)
		{
			counter--;

		}
	}
}