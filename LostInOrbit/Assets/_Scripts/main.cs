using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{


    public bool left_mov;
    public bool right_mov;
    public bool down_mov;
    public GameObject falling_block;
    public GameObject[] polycube;
    public GameObject go;
    public float fallSpeed = 2f;



    // Start is called before the first frame update
    void Start()
    {
        

        Invoke("SpawnBlock", 0);
        Invoke("BlockFall", 1f * fallSpeed);
    }

    public void SpawnBlock()
    {
        int ndx = Random.Range(0, polycube.Length);

        GameObject go = Instantiate<GameObject>(polycube[ndx]);

        go.tag = "falling_block";
        go.layer = 6;

        Vector3 pos = Vector3.zero;
        float ySpawn = 11f;
        pos.y = ySpawn;
        pos.x = 0f;
        pos.z = 0f;
        go.transform.position = pos;
    }

    public void BlockFall()
    {
        falling_block = GameObject.FindGameObjectWithTag("falling_block");
        Vector3 pos = falling_block.transform.position;

        pos.y += -1;
        falling_block.transform.position = pos;

        Invoke("BlockFall", 1f * fallSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        falling_block = GameObject.FindGameObjectWithTag("falling_block");
        
        Vector3 pos = falling_block.transform.position;



        if (Input.GetKeyDown(KeyCode.A))
        {
            if (pos.z < 2)
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

    




}
