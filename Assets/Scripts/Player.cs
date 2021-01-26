using System;
using System.Collections;
using System.Collections.Generic;
using Patterns;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : IResetGame
{
    [Header("Player Scoring")] public int coins;
    public int Jumps;

    [Header("Player Settings")] public float JumpSpeed;
    
    // Hardness
    private float _JumpSpeed;
    
    // Boolean Checks
    private bool isJumping = false;
    
    // Get Reference
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
    private Vector2 StartPosition;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        StartPosition = _transform.position;
    }

    private void Start()
    {
        GameManager.Instance.currentPlayer = this;
        Register();
    }

    private void Update()
    {
        if (_rigidbody2D.velocity.sqrMagnitude < (0.3f * 0.3f)){
            _transform.rotation = Quaternion.Euler(0,0,-45);
            isJumping = false;
        }
        if (Input.GetMouseButtonDown(0) && isJumping == false && !GameManager.Instance.isGameEnded)
            Jump();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 8)
        {
            coins += other.GetComponent<Coin>().CoinWorth;
            // GC Will kill us. Pool them.
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.layer == 10)
        {
            GameManager.Instance.isGameEnded = true;
            
        }
    }

    public override void ResetGame()
    {
        coins = 0;
        Jumps = 0;
        _transform.position = StartPosition;
        _rigidbody2D.velocity = Vector2.zero;
    }

    private void Jump()
    {
        isJumping = true;
        _transform.rotation = Quaternion.Euler(0,0,45);
        Jumps++;
        //_JumpSpeed = JumpSpeed + (JumpSpeed * (Jumps / 100f)); 

        _rigidbody2D.velocity = Vector2.up * JumpSpeed;
    }

    private void OnDisable()
    {
        DeRegister();
    }
}
