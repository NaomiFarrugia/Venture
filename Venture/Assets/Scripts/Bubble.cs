using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
        // speed variable = 9
    [SerializeField]
    private float _speed = 9f;   

    // Update is called once per frame
    void Update()
    {

     transform.Translate(Vector3.right * _speed * Time.deltaTime);

     // if the laser position on Y is grater than 8
        if(transform.position.y > 8)
        {
         // destory the parent 
            if (transform.parent != null)
        {
            Destroy(transform.parent.gameObject);
        }

         // Destorys the gameobjet attached to THIS script
        Destroy(gameObject);
    }
}
}
