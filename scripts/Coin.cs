using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]private  int _coinRotateSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        transform.Rotate(0, _coinRotateSpeed*Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
    }
}
