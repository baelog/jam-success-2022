using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesCreatePojectil : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite sprite;
    public float trigger = 4;
    public GameObject projectil;
    public EnnemiesStats stats;

    private Transform player;
    private Vector3 direction;
    private float time = 0.0f;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log("je suis la");
        if (time >= trigger) {
            Debug.Log("je suisssssssssssssssssssssssssssssssss");
            Debug.Log(time);
            EnnemieProjectile info = projectil.GetComponent<EnnemieProjectile>();
            Instantiate(projectil, transform.position, Quaternion.identity);
            info.projectile = sprite;
            info.direction = player.position - transform.position;
            info.projectileSpeed = stats.projectilSpeed;
            time = 0.0f;
        }
        // Debug.Log("je suisssssssssssssssssssssssssssssssss");
    }
}
