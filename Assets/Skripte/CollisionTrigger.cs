using UnityEngine;
using System.Collections;

public class CollisionTrigger : MonoBehaviour {

    [SerializeField]
    GameObject platform;

    [SerializeField]
    Transform playerTrans;

    void Start()
    {
        spawnPlatformStart();
    }

    void spawnPlatformStart()
    {
        float yPos = -4f;
        float xPos = 0f;

        for (int i= 0; i < 6; i++)
        {
            xPos = Random.Range(-2f, 2f);
            Instantiate(platform, new Vector3(xPos, yPos, 0), Quaternion.identity);


            if(i <=0)
            {
                Instantiate(playerTrans, new Vector3(xPos, yPos +1f , 0f), Quaternion.identity);
            }
            yPos += 2f;
        }

    }
}
