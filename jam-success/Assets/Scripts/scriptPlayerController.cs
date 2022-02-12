using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class scriptPlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb2d;
    //public Text displayTips;
    public Animator anim;
    
    public static float timer;
    public static bool timeStarted = false;

    void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if (timeStarted == true) 
        {
            timer += Time.deltaTime;
            print(timer);
        }       
    }

    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical   = Input.GetAxis("Vertical");

        if (timeStarted == true && (timer%60) >= 1) {
            timeStarted = false;
            moveSpeed = 5;
            print("end trimer");
        }
        if (Input.GetKeyDown(KeyCode.Space) && timeStarted == false)//dash
        {
            moveSpeed = 50;
            print("launch trimer");
            timer = 0;
            timeStarted = true;
        }
        

        rb2d.AddForce(new Vector2 (movHorizontal * moveSpeed, movVertical * moveSpeed));
        anim.SetFloat("Speedx", rb2d.velocity.x);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        /*if (other.gameObject.CompareTag("Tips"))
        {
            Destroy(other.gameObject);
            GlobalesVariables.lettre = GlobalesVariables.lettre + 1;
            switch (GlobalesVariables.lettre)
            {
                case 1:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f _ _ _ _ _ _ _";
                    break;
                case 2:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r _ _ _ _ _ _";
                    break;
                case 3:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p _ _ _ _ _";
                    break;
                case 4:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p s _ _ _ _";
                    break;
                case 5:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p s x _ _ _";
                    break;
                case 6:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p s x w _ _";
                    break;
                case 7:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p s x w h _";
                    break;
                case 8:
                    displayTips.text = "Indices pour le mot de passe:\nEncrypté: f r p s x w h u";
                    break;
                case 9:
                    displayTips.text = "Indices pour le mot de passe:\nDécrypté: c o m p u t e r";
                    break;
            }
        }*/
    }
}