using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class attack : MonoBehaviour
{
    public bool e1, e2, e3, e4, e5, e6;
   public GameObject mainmeny;
    public GameObject atackmeny;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {
        atackmeny.GetComponent<Canvas>().enabled = true;
        mainmeny.GetComponent<Canvas>().enabled = false;
    }
}
