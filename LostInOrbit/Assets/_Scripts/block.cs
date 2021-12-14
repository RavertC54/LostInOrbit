using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void Lateral_Movement(bool lateral)
    {

        //Left movement +z
        if (lateral)
        {

            this.gameObject.Transform.position(0, 0, 1);
        }
        //Right movement -z



    }

}
