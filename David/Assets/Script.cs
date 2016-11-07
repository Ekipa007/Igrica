using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Script : MonoBehaviour {
	public GameObject MainGameObject;
	public GameObject StatistikaGameObject;


	public void StatistikaMenu(){
		MainGameObject.SetActive (false);
		StatistikaGameObject.SetActive (true);
	}

	public void MainMenu(){
		MainGameObject.SetActive (true);
		StatistikaGameObject.SetActive (false);
	}

	public void Quit()
	{
		Application.Quit();
	}

}
