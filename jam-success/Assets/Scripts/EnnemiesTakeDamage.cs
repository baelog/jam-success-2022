using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesTakeDamage : MonoBehaviour
{
    public EnnemiesStats stats;

    public void takedamage(int damage)
    {
        stats.heath -= damage;
    }
}
