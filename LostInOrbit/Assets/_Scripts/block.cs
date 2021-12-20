using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public float fallSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject go = GameObject.FindGameObjectWithTag("falling_block");

        GameObject otherGO = coll.gameObject;
        if (otherGO.layer == 6)
        {
            go.tag = "floor";
            Invoke("SpawnBlock", 1f * fallSpeed);
            print("Object Collided With Block");
        }
    }

}
