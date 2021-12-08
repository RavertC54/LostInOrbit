using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floater : MonoBehaviour
{

    public GameObject pane1;
    public GameObject pane2;
    public GameObject[] floaters;
    public int ticCount;

    // Start is called before the first frame update
    void Start()
    {
        pane1 = GameObject.Find("Floating_pane");
        pane2 = GameObject.Find("Floating_pane (1)");
        floaters = GameObject.FindGameObjectsWithTag("floater");






    }

    // Update is called once per frame
    void Update()
    {
        pane1.transform.Rotate(8 * Time.deltaTime, 0, 0);
        pane2.transform.Rotate(0, 6 * Time.deltaTime, 0);
        foreach (GameObject tool in floaters) 
        {
            ticCount++;
            if ((ticCount % 2) == 0)
            {
                tool.transform.Rotate(0, Mathf.Abs(Mathf.Cos(Time.deltaTime)) * 7 * Time.deltaTime, 0);
            }
            else
            {
                tool.transform.Rotate(Mathf.Abs(Mathf.Cos(Time.deltaTime)) * 7 * Time.deltaTime, 0, 0);
            }

            // Work on a variation of an oscilliatory function for the floating space objects as well as using one bar for several objects
            //tool.transform.Rotate(Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup)) * Time.deltaTime, Mathf.Abs(Mathf.Cos(Time.realtimeSinceStartup)) * Time.deltaTime, 0);
            //tool.transform.Rotate(8 * Time.deltaTime, 6 * Time.deltaTime, 0);

        }

    }
}
