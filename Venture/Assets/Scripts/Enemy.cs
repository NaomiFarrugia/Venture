using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    private Submarine _Submarine; 

    private Animator _animator;

    private int _direction;

    void Start()
    {
        _Submarine = GameObject.FindObjectOfType<Submarine>();
        _direction = (int) Mathf.Sign(Random.Range(-1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        // move left at 3m/s
        transform.Translate(Vector3.up * _direction * _speed * Time.deltaTime);
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
            OnEnemyDeath();
            }
        }
        // if the other is a bubble
        // destroy the bubble
        // destroy us
        if (other.tag == "Bubble")
        {
            _Submarine.AddScore();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    void OnEnemyDeath()
    {
        Destroy(this.gameObject);
    }
    
} 

