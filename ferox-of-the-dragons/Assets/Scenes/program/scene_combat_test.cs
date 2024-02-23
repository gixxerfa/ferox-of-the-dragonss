using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_combat_test : MonoBehaviour
{
    public bool fl;
    
    // Start is called before the first frame update
    void Start()
    {
        fl = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && fl == false)
        {
            SceneManager.LoadScene("combat_test");
            fl = true;
        }
    }
}
