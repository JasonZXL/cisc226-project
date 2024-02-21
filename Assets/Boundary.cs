using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4){
            transform.position = new Vector3(transform.position.x, 4, 0);
            
        }
        else if(transform.position.y <= -4){
            transform.position = new Vector3(transform.position.x, -4, 0);
        }

        if(transform.position.x >= 10.21f){
            transform.position = new Vector3(10.21f, transform.position.y, 0);
        }
        else if(transform.position.x <= -10){
            transform.position = new Vector3(-10, transform.position.y, 0);
        }
    }
}
