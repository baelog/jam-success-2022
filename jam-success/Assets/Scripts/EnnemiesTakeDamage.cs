using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesTakeDamage : MonoBehaviour
{
    public EnnemiesStats stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage(int damage)
    {
        stats.heath -= damage;
        if (stats.heath <= 0)
            DeleteEnnemies();
    }

    void DeleteEnnemies()
    {
        Destroy(this.gameObject);
    }
}
