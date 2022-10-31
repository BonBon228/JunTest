using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    private float _cubeSpawnDelay;
    private PlayerInput _playerInput;
    private float _timer;

    private void Awake()
    {
        _playerInput = FindObjectOfType<PlayerInput>();
    }

    private void Update()
    {
        CubeSpawn();
    }

    private void CubeSpawn()
    {
        _cubeSpawnDelay = _playerInput.delay;
        _timer += Time.deltaTime;

        if(_timer >= _cubeSpawnDelay)
        {
            GameObject cube = ObjectPool.instance.GetPooledObject();

            if(cube != null)
            {
            cube.transform.position = new Vector3(0, 0, 0);
            cube.SetActive(true);
            }
            _timer = 0f;
        }
    }
}
