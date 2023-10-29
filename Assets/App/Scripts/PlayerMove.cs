using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed = 2.0f;
    [SerializeField] private float _jumpHeight = 1.0f;
    [SerializeField] private float _gravity = -9.81f;

    private CharacterController _controller;
    private Vector3 _playerVelocity;

    private void Start()
    {   
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        bool groundedPLayer = _controller.isGrounded;
        if (groundedPLayer && _playerVelocity.y < 0)
        _playerVelocity.y = 0f;
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        _controller.Move(move * Time.deltaTime * _playerSpeed);
        

    if (Input.GetButton("Jump") && groundedPLayer)
    _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -2.0f * _gravity);

    _playerVelocity.y += _gravity * Time.deltaTime;
    _controller.Move(_playerVelocity * Time.deltaTime);
        
    }
}
