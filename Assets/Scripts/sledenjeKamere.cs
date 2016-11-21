using UnityEngine;
using System.Collections;

public class sledenjeKamere : MonoBehaviour {

	[SerializeField]
	managerIgre gameManagerScript;

	public Transform player;

	Vector3 startPos;
	Vector3 followPos;
	float yPos;

	void Awake(){

		followPos = new Vector3 (transform.position.x, 0, transform.position.z);
		startPos = transform.position;
	}

	void Start(){

		ResetCam ();

	}

	void Update () {
	
		if (gameManagerScript.gameRunning)
			Follow ();

	}

	void Follow(){

		yPos = Mathf.Max (yPos, player.position.y);

		transform.position = followPos + (Vector3.up * yPos);

	}

	public void ResetCam(){

		transform.position = startPos;
		yPos = startPos.y;
	}
}
