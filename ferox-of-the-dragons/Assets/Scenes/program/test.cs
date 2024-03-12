using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(hp <= 0 )
        {
            SceneManager.LoadScene("TEST_PROGRAM");
            //fl = false;
        }
    }
    public void Hurt()
    {
        TakeDamage(5);
        print("work");
    }
}
