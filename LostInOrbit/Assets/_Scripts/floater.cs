using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class floater : MonoBehaviour
{
    System.Random rnd = new System.Random();
    public GameObject[] floaters;


    // Start is called before the first frame update
    void Start()
    {
        floaters = GameObject.FindGameObjectsWithTag("floater");
        foreach (GameObject tool in floaters)
        {
            tool.transform.Rotate(rnd.Next(180), rnd.Next(180), rnd.Next(180));
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject tool in floaters)
        {
            tool.transform.Rotate(6 * Time.deltaTime, Time.deltaTime, 0);
            //tool.transform.Rotate(Time.deltaTime * 4, -7 * Time.deltaTime, 0);

        }
    }
}
