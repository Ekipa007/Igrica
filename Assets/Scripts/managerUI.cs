using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class managerUI : MonoBehaviour {

	[SerializeField]
	GameObject mainMenuPanel;

	public void GameEnd(bool showGOver){
		mainMenuPanel.SetActive (true);
	}

	public void GameStart(){
		mainMenuPanel.SetActive (false);
	}
}
