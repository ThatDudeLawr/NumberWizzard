using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level load is requested for " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest(){
		Debug.Log("Quit request has been sent");
		Application.Quit();
	}

	}