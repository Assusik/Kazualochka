using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float _oldMousePositionX;
    private float _eulerY;
    [SerializeField] private float _speed;
    [SerializeField] private float _sensivity;
    [SerializeField] private Animator _animator;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            _oldMousePositionX = Input.mousePosition.x;
            _animator.SetBool("Run", true);
        }

        

      
        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;

            newPosition.x = Mathf.Clamp(newPosition.x, -5.8f, 5.8f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _eulerY += deltaX * _sensivity;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("Run", false);
        }


    }
}
