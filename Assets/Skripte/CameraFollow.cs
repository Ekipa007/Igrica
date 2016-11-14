using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    [SerializeField]
    Transform player;

    Vector3 followPos;
    float yPos;

    void Awake()
    {
        followPos = new Vector3(transform.position.x, 1, transform.position.z);
    }

	// Use this for initialization


	void Start () {

        yPos = player.position.y;
        transform.position = followPos + (Vector3.up * yPos);
	}
	
	// Update is called once per frame
	void Update () {
        yPos = Mathf.Max(yPos, player.position.y);
        transform.position = followPos + (Vector3.up * yPos);
	}
}
