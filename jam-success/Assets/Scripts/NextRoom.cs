using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    public Vector3 deplacement;
    Camera m_MainCamera;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        m_MainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        m_MainCamera.GetComponent<Transform>().Translate(-deplacement);
        player.Translate(deplacement / 3);
    }
}
