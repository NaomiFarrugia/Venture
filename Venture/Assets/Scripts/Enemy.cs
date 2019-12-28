using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    private Submarine _Submarine; 

    private Animator _animator;

    void Start()
    {
        _Submarine = GameObject.Find("Submarine").GetComponent<Submarine>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // move left at 3m/s
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (transform.position.x < -4)
        {
            transform.position = new Vector3(Random.Range(-4f, 4f), 4, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      // if the other is the submarine
      // damage the submarine
      // destroy us
    if (other.tag == "Submarine")
    {
        Submarine Submarine = other.GetComponent<Submarine>();
        if (Submarine != null)
        {
        Submarine.Damage();
        }
    }
    // if the other is a bubble
    // destroy the bubble
    // destroy us
    if (other.tag == "Bubble")
    {
        //_Submarine.AddScore();
        Destroy(other.gameObject);
        OnEnemyDeath();
    }
    }

    void OnEnemyDeath()
    {
        _animator.SetTrigger("OnEnemyDeath");
        _speed= 0;
        Destroy(this.gameObject, 2.633f);
    }
} 

