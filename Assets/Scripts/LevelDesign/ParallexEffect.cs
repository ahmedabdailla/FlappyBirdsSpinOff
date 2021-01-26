using System;
using System.Collections;
using System.Collections.Generic;
using Patterns;
using UnityEngine;
using UnityEngine.Events;

public class ParallexEffect : IResetGame
{
    [Header("Factors")] public float speed;
    public float ResetAt;
    
    private Transform _transform;
    private Vector3 OriginalPosition;

    public UnityEvent OnReset;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
        OriginalPosition = _transform.position;
    }

    private void Start()
    {
        Register();
        StartCoroutine(OnCustomUpdate());
    }

    IEnumerator OnCustomUpdate()
    {
        while (!GameManager.Instance.isGameEnded)
        {
            if (_transform.position.x <= ResetAt){
                _transform.position = OriginalPosition;
                OnReset.Invoke();
            }
            else
            {
                _transform.position -= new Vector3(speed, 0);
            }
            
            yield return new WaitForFixedUpdate();
        }
    }

    public override void ResetGame()
    {
        _transform.position = OriginalPosition;
        OnReset.Invoke();
        StopAllCoroutines();
        StartCoroutine(OnCustomUpdate());
    }

    private void OnDisable()
    {
        DeRegister();
    }
}
