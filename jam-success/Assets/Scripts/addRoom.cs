using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RoomTamplate template;
        template = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTamplate>();
        template.listOfRooms.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
