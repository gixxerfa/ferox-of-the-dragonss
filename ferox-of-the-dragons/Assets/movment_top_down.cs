using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment_top_down : MonoBehaviour
{
    public float movex, moveZ, movespeed;
    public Vector3 movedir;
    public CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // more or less just like wasd controlls 
        movex = Input.GetAxis("Horizontal");
        // vertical controlls this time is the camera contoll  
        moveZ = Input.GetAxis("Vertical");
        // it's a vector3 
        movedir = transform.forward * moveZ + transform.right * movex;
        // same stuff as before but now it's for just playe movespeed
        controller.Move(movedir * Time.deltaTime * movespeed);
    }
}
