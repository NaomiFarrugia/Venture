using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    private Submarine _Submarine; 

    private Animator _animator;

    void Start()
    {
        _Submarine = GameObject.FindObjectOfType<Submarine>(); 
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Submarine")
        {
            Submarine Submarine = other.GetComponent<Submarine>();
            if (Submarine != null)
            {
                // score
                // destroy this
                _Submarine.AddScore();
                Destroy(this.gameObject);
            }
        }
    }
}