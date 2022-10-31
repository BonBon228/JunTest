using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    private List<GameObject> _pooledObjects = new List<GameObject>();
    private int _amountToPool = 30;
    [SerializeField]
    private GameObject _cubePrefab;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for(int i = 0; i < _amountToPool; i++)
        {
            GameObject obj = Instantiate(_cubePrefab);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < _pooledObjects.Count; i++)
        {
            if(_pooledObjects[i].activeInHierarchy == false)
            {
                return _pooledObjects[i];
            }
        }

        return null;
    }
}
