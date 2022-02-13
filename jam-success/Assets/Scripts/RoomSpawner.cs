using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirenction = 0;
    private RoomTamplate templates;
    private int rand;
    public bool spawned = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTamplate>();
        Invoke("Spawn", 0.1f);
    }

    // Update is called once per frame
    void Spawn()
    {
        if (spawned == false) {
            if (openingDirenction == 2) {
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                // BOTTOM
            }
            if (openingDirenction == 1) {
                // TOP
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            if (openingDirenction == 4) {
                // LEFT
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            if (openingDirenction == 3) {
                // RIGHT
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Room"))
            Destroy(gameObject);
        if (other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == false) {
            spawned = true;
            Destroy(gameObject);
        }
    }
}
