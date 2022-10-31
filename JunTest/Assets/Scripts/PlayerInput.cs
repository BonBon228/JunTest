using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInput : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    [HideInInspector]
    public float distance;
    [HideInInspector]
    public float delay;
    [SerializeField]
    private TMP_InputField _cubeSpeedInputField;
    [SerializeField]
    private TMP_InputField _pathDistanceInputField;
    [SerializeField]
    private TMP_InputField _cubeSpawnDelayInputField;

    
    void Update()
    {
        if(float.TryParse(_cubeSpeedInputField.text, out speed))
        {
            speed = float.Parse(_cubeSpeedInputField.text);
        }
        if(float.TryParse(_pathDistanceInputField.text, out distance))
        {
            distance = float.Parse(_pathDistanceInputField.text);
        }
        if(float.TryParse(_cubeSpawnDelayInputField.text, out delay))
        {
            delay = float.Parse(_cubeSpawnDelayInputField.text);
        }
    }
}
