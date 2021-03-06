﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerIgre : MonoBehaviour {

	[SerializeField]
	managerUI uiManagerScript;

	[SerializeField]
	generatorPlatform platformSpawnerScript;

	[SerializeField]
	sledenjeKamere cameraScript;

	public kontroleIgralca playerScript;

	public bool gameRunning = false;

	public void GameOver(){

		gameRunning = false;
		cameraScript.ResetCam ();
		playerScript.Reset ();
		platformSpawnerScript.ClearSpawnedPlatform ();
		platformSpawnerScript.enabled = false;

	}

	public void UIRestart(bool showGO){

		uiManagerScript.GameEnd(showGO);
	}

	public void StartGame(){

        platformSpawnerScript.enabled = true;
		uiManagerScript.GameStart ();
		playerScript.isDead = false;
		gameRunning = true;

	}

	public void QuitGame(){

		Application.Quit();

	}
}
