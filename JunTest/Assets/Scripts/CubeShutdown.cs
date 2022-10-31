using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShutdown : MonoBehaviour
{
    private float _distance;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = FindObjectOfType<PlayerInput>();
    }

    private void Update()
    {
        ShutdownCube();
    }

    private void ShutdownCube()
    {
        _distance = _playerInput.distance;
        Vector3 goPos = gameObject.transform.position;
        if(goPos.z >= _distance)
        {
            gameObject.SetActive(false);
        }
    }
}
