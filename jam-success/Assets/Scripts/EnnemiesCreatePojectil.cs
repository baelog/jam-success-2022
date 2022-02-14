using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesCreatePojectil : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite sprite;
    public float trigger = 4.0F;
    public GameObject projectil;
    public EnnemiesStats stats;

    private Transform player;
    private Vector3 direction;
    private float time;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    bool OnTheRoom()
    {
        // if (x > x1 && x < x2 && y > y1 && y < y2)
        //     return true;
 
        // return false;
        if (player.position.x > transform.position.x - 9 && player.position.y > transform.position.y - 5 && player.position.x < transform.position.x + 9 && player.position.y < transform.position.y + 5)
            return true;
        return false;
    }

    void Update()
    {
        if (OnTheRoom() == true) {
            time += Time.deltaTime;
            if (time >= trigger) {
                EnnemieProjectile info = projectil.GetComponent<EnnemieProjectile>();
                info.projectile = sprite;
                info.direction = player.position - transform.position;
                info.projectileSpeed = stats.projectilSpeed;
                Instantiate(projectil, transform.position, Quaternion.identity);
                time = 0.0f;
                Debug.Log("je tire");
            }
        }
    }
}
