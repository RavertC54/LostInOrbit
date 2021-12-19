using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class main : MonoBehaviour
{


    public bool left_mov;
    public bool right_mov;
    public bool down_mov;
    public GameObject falling_block;




    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        falling_block = GameObject.FindGameObjectWithTag("falling_block");

        float speedScale = 1f;

        Vector3 pos = falling_block.transform.position;



        if (Input.GetKeyDown(KeyCode.A))
        {
            if (pos.z < 3)
            {
                pos.z += 1;
                falling_block.transform.position = pos;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (pos.z > -3)
            {
                pos.z -= 1;
                falling_block.transform.position = pos;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (pos.y >= -1)
            {
                pos.y += -1;
                falling_block.transform.position = pos;
            }
            
        }

    }

    //Spawning the new blocks




}
