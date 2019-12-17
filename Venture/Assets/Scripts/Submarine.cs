using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    [SerializeField] float m_Speed = 3f;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        float vert = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * vert * m_Speed * Time.deltaTime);

        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     //Move the Rigidbody upwards constantly at speed you define (the green arrow axis in Scene view)
        //     m_Rigidbody.velocity = transform.up * 3f;
        // }

        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     //Move the Rigidbody downwards constantly at the speed you define (the green arrow axis in Scene view)
        //     m_Rigidbody.velocity = -transform.up * 3f;
        // }
    }
}
