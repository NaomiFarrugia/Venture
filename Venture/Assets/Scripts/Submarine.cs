using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    [SerializeField] float m_Speed = 3f;

    [SerializeField]
    private int _lives = 3;

    [Header("Bubble")]
    [SerializeField]
    private GameObject _BubblePrefab;

    [SerializeField]
    private float _fireRate = 0.5f;

    private float _nextFire = -1f;

    private SpawnManager _spawnManager;

    private UIManager _UIManager;

    private GameManager _GameManager;


    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        CalculateMovement();

        // if I hit the space key and the game time is greater than nextFire
        // spawn bubble
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            FireBubble();
        }
    }
        void CalculateMovement()   
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
        void FireBubble()
    {
        _nextFire = Time.time + _fireRate;

        // Bubble is spawing at the player's position
        // Queaternion.identity = default rotation (0 degrees)
            Vector3 bubblePos = transform.position + new Vector3(0, -1.2201f, 1.100f);
            Instantiate(_BubblePrefab, bubblePos, Quaternion.identity);
    }

    public void Damage()
    {
        //reduce lives by 1
        _lives -= 1;

        //check if dead
        // destroy us
        if (_lives < 1)
        {
            _spawnManager.OnPlayerDeath();
            Destroy(this.gameObject);
        }
        _UIManager.UpdateLives(_lives);
    }

    public void AddScore()
    {
        _score += 1;
        //communicate with the UI Manager and visualize the score
        _UIManager.SetScoreText(_score);
    }

}
