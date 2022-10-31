using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private float _cubeSpeed;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = FindObjectOfType<PlayerInput>();
    }

    private void Update()
    {
        MoveCube();
    }

    private void MoveCube()
    {
        _cubeSpeed = _playerInput.speed;
        Vector3 startPos = new Vector3(0, 0, 0);
        Vector3 moveDir = new Vector3(0, 0, _cubeSpeed * Time.deltaTime);
        gameObject.transform.Translate(moveDir);
    }
}
