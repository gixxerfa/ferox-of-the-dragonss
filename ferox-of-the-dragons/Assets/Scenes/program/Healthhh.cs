using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthhh : MonoBehaviour
{
    public int HP;


    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void TakeDamage(int _damage)
    {
        HP -= _damage;

    }
}