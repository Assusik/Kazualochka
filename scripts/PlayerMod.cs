using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMod : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;

     float _widhtMultiplayer = 0.0005f;
     float _heightMultiplayer = 0.01f;

    [SerializeField] private Renderer _renderer;
    [SerializeField] private Transform _topSpine;
    [SerializeField] private Transform _bottomSpine;

    [SerializeField] private Transform _coliderTranform;
    

    
    void Update()
    {
        float offsetY = _height * _heightMultiplayer;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY+0.17f, 0);
        _coliderTranform.localScale = new Vector3(1, 2f + offsetY, 1);

        
    }
    public void AddWidth(int value)
    {
     
        _width += value;
        UpdateWidth();
    }
    public void AddHeight(int value)
    {
        _height+= value;
       
    }
    public void HitBarier(int damage)
    {
        if (_height>0)
        {
            _height -= damage;
        }
        else if (_width>0)
        {
            _width -= damage;
            UpdateWidth();
        }
        else
        {
            Die();

        }

    }
    public void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widhtMultiplayer);
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
