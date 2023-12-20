using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PreFinishMove _preFinishMove;
    [SerializeField] Animator _animator;
    void Start()
    {
        _playerMove.enabled = false;
        _preFinishMove.enabled = false;

    }

    
    void Update()
    {
        
        
    }
    public void Play()
    {
        _playerMove.enabled = true;
    }

    public void StartPreFinishBehaviour()
    {
        _playerMove.enabled = false;
        _preFinishMove.enabled = true;
    }
    public void StartFinishBehaviour()
    {
        _preFinishMove.enabled = false;
        _animator.SetTrigger("Dance");
    }
}
