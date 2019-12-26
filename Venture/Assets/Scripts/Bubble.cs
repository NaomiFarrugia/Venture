using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
        // speed variable = 10
    [SerializeField]
    private float _speed = 10f;   

    // Update is called once per frame
    void Update()
    {
      // translate the laser right
     transform.Translate(Vector3.right * _speed * Time.deltaTime);

     // if the laser position on Y is grater than 8
     // Destroy laser
        if(transform.position.y > 8)
        {
         // if the laser is parented to a triple shot
         // destory the parent 
            if (transform.parent != null)
        {
            Destroy(transform.parent.gameObject);
        }

         // Destorys the gameovjet attached to THIS script
        Destroy(gameObject);
    }
}
}
