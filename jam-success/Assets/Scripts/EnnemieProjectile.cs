using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite projectile;
    public Vector3 direction;
    public float projectileSpeed = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(direction * projectileSpeed * Time.deltaTime);
        
    }
}
