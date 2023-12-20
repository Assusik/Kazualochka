using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    [SerializeField] private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;
    [SerializeField] private Color _bodyColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isAlive;

    [SerializeField] private Light _sun;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _transform;
 
    void Start()
    {
        transform.localScale = new Vector3(1, _height, 1);
        gameObject.name = _name;
        gameObject.SetActive(_isAlive);
        transform.position = _startPosition;
        gameObject.GetComponent<Renderer>().material.color = _bodyColor;

        _camera.fieldOfView = 120;
    }

    void Update()
    {
        _transform.position = transform.position + new Vector3(0, 3, 0);
     
    }
}
