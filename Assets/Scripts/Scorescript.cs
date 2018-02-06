using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorescript : MonoBehaviour {
public GameObject Player; 
public int Score;

	// Use this for initialization
	void Start () {
	Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.Label(new Rect(10, 10, 100, 100), "Score: " + Score);
	} 

	void OnCollisionEnter(Collision variable){ 
		if(variable.gameObject == Player){ 
			Player.GetComponent<Scorescript>().Score += 1; 
			Destroy(gameObject); 
		} 
	} 
}
