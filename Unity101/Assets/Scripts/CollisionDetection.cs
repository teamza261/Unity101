using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("hit");

        if (collision.gameObject.tag == "ThirdFloor")
        {
            print("Hit 3rd Floor");
        }
        if (collision.gameObject.tag == "SecondFloor")
        {
            print("Hit 2nd Floor");
        }
        if (collision.gameObject.tag == "FirstFloor")
        {
            print("Hit 1st Floor"); 
        }
    }
}

