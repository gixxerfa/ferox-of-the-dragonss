using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : Healthhh
{
    // Start is called before the first frame update
    void Start()
    {
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt()
    {
        TakeDamage(5);
        print("work");
    }
}
