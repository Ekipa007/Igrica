using UnityEngine;
using System.Collections;

public class kontroleIgralca : MonoBehaviour
{

    public Transform cameraTrans;

    public managerIgre gameManagerScript;

    [SerializeField]
    Vector3 firstPos;

    [SerializeField]
    float playerFirstYPos;

    [SerializeField]
    float moveSpd;

    [SerializeField]
    float jumpPower;

    Rigidbody2D myRigidbody2d;
    WaitForSeconds waitFallSound;

    public bool isDead = false;

    void Awake() {
        myRigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Start() {
        StartCoroutine(ImAlive());
    }

    public void Reset(){
        myRigidbody2d.velocity = Vector3.zero;
        transform.position = firstPos;
    }

    void Update() {
        if (gameManagerScript.gameRunning) {
            kontroleTouch();
            CheckIfDead();
        }
    }

    void FixedUpdate() {
        if (gameManagerScript.gameRunning)
            Movement();
    }

    void OnCollisionEnter2D(Collision2D col) {
         if (col.gameObject.CompareTag("Jumpable")) {
            myRigidbody2d.velocity = new Vector2(myRigidbody2d.velocity.x, 0f);
            myRigidbody2d.AddForce(Vector2.up * jumpPower);
        }
    }

    int TouchInput() {
        #if UNITY_EDITOR
        if (Application.isPlaying)
            return Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        #endif
        return 0;
    }

    void Movement() {
        myRigidbody2d.AddForce(Vector2.right * TouchInput() * moveSpd);
        float maxXVel = Mathf.Clamp(myRigidbody2d.velocity.x, -5f, 5f);
        myRigidbody2d.velocity = new Vector2(maxXVel, myRigidbody2d.velocity.y);
    }

    void kontroleTouch()  {
        if (TouchInput() < 0 && transform.localScale.x > 0)
            transform.localScale = Vector3.one - (Vector3.right * 2);
        else if (TouchInput() > 0 && transform.localScale.x < 0)
            transform.localScale = Vector3.one;
    }

    void CheckIfDead() {
        if (transform.position.y <= cameraTrans.position.y - 8f && !isDead) {
            isDead = true;
            StartCoroutine(ImDead());
        }
    }

    IEnumerator ImDead()    {
        yield return waitFallSound;

        gameManagerScript.GameOver();

        yield return waitFallSound;
        yield return waitFallSound;
        yield return waitFallSound;

        gameManagerScript.UIRestart(true);
    }

    IEnumerator ImAlive()    {

        yield return waitFallSound;

        Reset();

        yield return waitFallSound;
        yield return waitFallSound;
        yield return waitFallSound;

        gameManagerScript.UIRestart(false);
    }
}
