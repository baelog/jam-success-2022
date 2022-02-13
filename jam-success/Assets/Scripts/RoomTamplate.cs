using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTamplate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public List<GameObject> listOfRooms;

    private float waitTime = 4;
    public GameObject boss;
    public GameObject monster;

    void Update()
    {
        if (waitTime < 0) {
            for (int i = 0; i < listOfRooms.Count; ++i) {
                if (i == listOfRooms.Count - 1) {
                    Instantiate(boss, new Vector3(listOfRooms[i].transform.position.x, listOfRooms[i].transform.position.y, 0), Quaternion.identity);
                } else {
                    Instantiate(monster, new Vector3(listOfRooms[i].transform.position.x, listOfRooms[i].transform.position.y, 0), Quaternion.identity);
                }
            }
        } else {
            waitTime -= Time.deltaTime;
        }
    }
}
