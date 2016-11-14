using UnityEngine;
using System.Collections;

public class premikanjeLika : MonoBehaviour {

    /*[SerializeField]
    public float movingSpeed;*/

    [SerializeField]
    public float jumpingSpeed = 400;

    Rigidbody2D myRigidbody2d;

    void Awake()
    {
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       // myRigidbody2d.AddForce(Vector2.right * Input.GetAxis("Horizontal") * movingSpeed);
        Movement();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        myRigidbody2d.AddForce(Vector2.up * jumpingSpeed);
    }

    void Movement() {
        /*if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 5f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.right * 5f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }*/

        //if (Input.touchCount == 1)
        if (Input.touchCount > 0)
        {
            //var touch = Input.touches[0];
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                transform.Translate(Vector2.right * 5f * Time.deltaTime);
                transform.eulerAngles = new Vector2(0, 180);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                transform.Translate(Vector2.right * 5f * Time.deltaTime);
                transform.eulerAngles = new Vector2(0, 0);
            }
        }
    }
}
