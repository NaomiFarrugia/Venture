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
    }
}
