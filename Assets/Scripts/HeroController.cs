using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float movementSpeed;
    private Vector3 movementInput;
    
    void Update()
    {
        HandleMovementInput();
        
    }

    private void FixedUpdate()
    {
        SetHeroMovement();
    }

    private void SetHeroMovement()
    {
        transform.position += CalculateMovement(movementInput.x, movementInput.z, movementSpeed, Time.fixedDeltaTime);
    }

    private void HandleMovementInput()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.z = Input.GetAxisRaw("Vertical");
    }

    public Vector3 CalculateMovement(float _horizontal, float _vertical, float _movementSpeed, float _deltatime )
    {
        float x = _horizontal * _movementSpeed * _deltatime;
        float z = _vertical * _movementSpeed * _deltatime;

        return new Vector3(x, 0f, z);
    }
}
