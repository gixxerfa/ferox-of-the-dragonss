using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_overworld_1 : MonoBehaviour
{
    public bool DEATHe;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (DEATHe == true && CompareTag("Player"))
        {
            SceneManager.LoadScene("TEST_PROGRAM");

        }
    }
   
}