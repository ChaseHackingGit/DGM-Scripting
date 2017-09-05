using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	
	int max = 100;
	int min = 1;
	int guess = 50;


	// Use this for initialization
	void Start ()
	{
		max = max + 1;
		print ("Hey there, sexy! fancy meeting you here!");
		print ("pick a number in your head");

		print ("the highest number you can pick is "+max);
		print ("the lowest number you can pick is "+min);

		print ("is the number higher or lower than "+guess);
		print ("up arrow for higher, down for lower, enter for equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("fun stuff");
			print ("other stuff");
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("far out, home slice.");
			print ("that's pretty rad.");
			{
				min = guess;
				guess = (max + min) / 2;
				print ("is the the humber higher or lower than" + guess);

	}
	if (Input.GetKeyDown (KeyCode.Return)) {
		print ("yo yo diggy dog");
				print ("figures I'd beat you.");
	}
		
