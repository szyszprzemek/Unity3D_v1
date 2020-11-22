using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")){
        	transform.Rotate(2f, 0f, 0f);
        }

        if (Input.GetKey("e")){
        	transform.Rotate(-2f, 0f, 0f);
        }
    }
}
