using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rot : MonoBehaviour

   
{

    private float vel = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,360 * vel * Time.deltaTime);
    }
}
