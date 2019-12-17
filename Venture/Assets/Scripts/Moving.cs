using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed; 

    void Start ()
    {
        
    }

void Update ()
{
    transform.position += Vector3.right * speed * Time.deltaTime; 
}
}
