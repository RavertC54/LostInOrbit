using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class main : MonoBehaviour
{


    public bool left_mov;
    public bool right_mov;
    public GameObject falling_block;




    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        falling_block = GameObject.FindGameObjectWithTag("falling_block");

        left_mov = false;
        right_mov = false;

        if (Input.GetKeyDown(KeyCode.A))
        {
            left_mov = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            right_mov = true;
        }
        //Left movement +z
        if (left_mov)
        {
            Vector3 pos = falling_block.transform.position;
            pos.z += 1;
            falling_block.transform.position = pos;
        }

        //Right movement -z
        if (right_mov)
        {
            Vector3 pos = falling_block.transform.position;
            pos.z -= 1;
            falling_block.transform.position = pos;
        }


    }

    //Spawning the new blocks




}
