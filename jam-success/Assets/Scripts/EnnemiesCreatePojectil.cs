using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesCreatePojectil : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite sprite;
    private Transform player;
    private Vector3 direction;
    public int speed;
    public float trigger = 4;
    private float time = 0.0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > trigger) {
            time -= trigger;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
