using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
     public float degreePerSeconds = 100f;
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         transform.Rotate(new Vector3(0, 0, degreePerSeconds * Time.deltaTime));
     } 

}


