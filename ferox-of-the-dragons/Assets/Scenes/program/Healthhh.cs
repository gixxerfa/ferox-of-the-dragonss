using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthhh : MonoBehaviour
{
    public int hp;
    public int maxhp;

   
    
    
    public virtual void TakeDamage(int _damage)
    {
        hp -= _damage;
        if(hp <= 0)
        {
            Destroy(gameObject);
        }

    }
    public virtual void start()
    {
        hp = maxhp;
    }
}