using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mytestscript : MonoBehaviour
{       

  
    // Start is called before the first frame update
    void Start()
    {
        //print("I'm a priny statement");
        //Debug.Log("Hello World");
        DebugExample();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed the 'a' key");

            Ray myRay = new Ray(transform.position, transform.forward);
            RaycastHit rayHit;

            if (Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
            {
                Debug.Log("Raycast distance :" + rayHit.distance);
            }

        }


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("YOu pressed the left mouse button." + Input.mousePosition);

        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("YOu pressed the left mouse button"+ Input.mousePosition);

        }


       
    }

    void DebugExample()
    {
        Debug.Log("Hello World");
        Debug.LogWarning("This is a warning message!");
        Debug.LogError("This is an error message!");

    }

    void Jump()
    {
        //

    }
}

