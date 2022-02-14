using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite projectile;
    public Vector3 direction;
    public float projectileSpeed = 0.5f;
    public int damage = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * projectileSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Banana") {
            if(col.gameObject.tag == "player") {
                //scriptPlayerController scriptPlayer = col.gameObject.GetComponent<scriptPlayerController>();
                //scriptPlayer.takeDamage(damage);
                Debug.Log("je usi la");
            }
        }
        Destroy(this.gameObject);
        Debug.Log("OnCollisionEnter2D");
    }
}
