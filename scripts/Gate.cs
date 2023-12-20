using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    height,
}

public class Gate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    [SerializeField] int _value;

    [SerializeField] DeformationType _deformationType;

    //УВелечение/ уменьшение ширины
    [SerializeField] GameObject _expandLable;
    [SerializeField] GameObject _shrinkLable;
    //УВелечение/ уменьшение высоты
    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLable;

    private void OnValidate()
    {
        string prefix = "";
        
        if (_value > 0)
        {
            prefix = "+";
            SetColor(_colorPositive);

        }else if (_value == 0)
        {
            SetColor(Color.grey);
        }
        else
        {
           SetColor(_colorNegative);
        }
        _text.text = prefix + _value.ToString();

        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);
        _expandLable.SetActive(false);

        if(_deformationType == DeformationType.Width)
        {
            if(_value >0)
            {
                _expandLable.SetActive(true);
            }
            else
            {
                _shrinkLable.SetActive(true);

            }
        }
        else
        {
            if (_value > 0)
            {
                _upLable.SetActive(true);
            }
            else
            {
                _downLable.SetActive(true);

            }
        }

   
    
    
    
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMod playerMod = other.attachedRigidbody.GetComponent<PlayerMod>();
        if (playerMod)
        {
            if (_deformationType == DeformationType.Width)
                playerMod.AddWidth(_value);

            else if (_deformationType == DeformationType.height)
            {
                playerMod.AddHeight(_value);
            }
        }
    }


    void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r,color.g,color.b,0.5f);

    }
    void Update()
    {
    }
}

