using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;


public class ScriptBananaLaunched : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveRange;
    private float startPos;
    public int newMoveDir;
    private int moveDir; // 0 = -x, 1 = +x, 2 = -y, default = +y
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveDir = newMoveDir;
        switch(moveDir)
        {
            case 0:
                startPos = transform.position.x;
                break;
            case 1:
                startPos = transform.position.x;
                break;
            case 2:
                startPos = transform.position.y;
                break;
            default:
                startPos = transform.position.y;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(moveDir)
        {
            case 0:
                if (Mathf.Abs(transform.position.x - startPos) <= moveRange)
                {
                    transform.position = new Vector3 (transform.position.x - speed, transform.position.y, 0);
                } else {
                    Destroy(gameObject);
                }
                break;
            case 1:
                if (Mathf.Abs(transform.position.x - startPos) <= moveRange)
                {
                    transform.position = new Vector3 (transform.position.x + speed, transform.position.y, 0);
                } else {
                    Destroy(gameObject);
                }
                break;
            case 2:
                if (Mathf.Abs(transform.position.y - startPos) <= moveRange)
                {
                    transform.position = new Vector3 (transform.position.x, transform.position.y - speed, 0);
                } else {
                    Destroy(gameObject);
                }
                break;
            default:
                if (Mathf.Abs(transform.position.y - startPos) <= moveRange)
                {
                    transform.position = new Vector3 (transform.position.x, transform.position.y + speed, 0);
                } else {
                    Destroy(gameObject);
                }
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag != "Projectile")
        {
            if (target.gameObject.tag == "Ennemies")
            {
                Debug.Log("Retirer un PV à un ennemie");
            }
            Destroy(gameObject);
        }
    }
}
