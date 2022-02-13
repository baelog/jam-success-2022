using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class scriptPlayerController : MonoBehaviour
{
    public float moveSpeed;
    public int pv;
    private Rigidbody2D rb2d;
    public Animator anim;
    public GameObject projectile;
    
    private static float timerBana;
    private static bool timeStartedBana = false;
    private static float timerDash;
    private static bool timeStartedDash = false;

    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (timeStartedBana == true) {
            timerBana += Time.deltaTime;
        }
        if (timeStartedDash == true) {
            timerDash += Time.deltaTime;
        }
        if (timeStartedBana == false) {
            if (Input.GetKeyDown(KeyCode.K)) {
                var newbanana = Instantiate(projectile, new Vector3(transform.position.x - 1.5F, transform.position.y, 0), Quaternion.identity);
                newbanana.GetComponent<ScriptBananaLaunched>().newMoveDir = 0;
                timeStartedBana = true;
                timerBana = 0;
            } else if (Input.GetKeyDown(KeyCode.M)) {
                var newbanana = Instantiate(projectile, new Vector3(transform.position.x + 1.5F, transform.position.y, 0), Quaternion.identity);
                newbanana.GetComponent<ScriptBananaLaunched>().newMoveDir = 1;
                timeStartedBana = true;
                timerBana = 0;
            } else if (Input.GetKeyDown(KeyCode.O)) {
                var newbanana = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 1.5F, 0), Quaternion.identity);
                newbanana.GetComponent<ScriptBananaLaunched>().newMoveDir = 3;
                timeStartedBana = true;
                timerBana = 0;
            } else if (Input.GetKeyDown(KeyCode.L)) {
                var newbanana = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y - 1.5F, 0), Quaternion.identity);
                newbanana.GetComponent<ScriptBananaLaunched>().newMoveDir = 2;
                timeStartedBana = true;
                timerBana = 0;
            } else if (Input.GetKeyDown(KeyCode.Space)) {
                timeStartedDash = true;
                timerDash = 0;
                moveSpeed *= 100;
            }
        }
        if (timeStartedBana == true && (timerBana%60) >= 0.3F) {
            timeStartedBana = false;
        }
        if (timeStartedDash == true && (timerDash%60) >= 0.2F) {
            timeStartedDash = false;
            moveSpeed /= 100;
            rb2d.velocity = new Vector2 (0.0F, 0.0F);
        }
    }

    void FixedUpdate() {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical   = Input.GetAxis("Vertical");

        
        rb2d.AddForce(new Vector2 (movHorizontal * moveSpeed, movVertical * moveSpeed));
        anim.SetFloat("Speedx", rb2d.velocity.x);
    }
    public void takeDamage(int damage) {
        pv -= damage;
        if (pv <= 0) {
            Debug.Log("Game Over");
        }
    }
}