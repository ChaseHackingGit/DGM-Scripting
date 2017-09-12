using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guess : MonoBehaviour {
	
	private int max = 100;
	private int min = 1;
	private int guess;

	 private int counter = 7;


	// Use this for initialization
	void Start ()
	{
		guess = Random.Range(min, max);
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
				print ("you win!");
			}

		}
		else if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than" + guess);
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number highter or lower than" + guess);
		}
		if (Input.GetKeyDown (KeyCode.Return))
		{
			print ("I win!");
		}

		if (counter == 0)
		{
			counter--;

		}
	}
}