using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;


public class Barier : MonoBehaviour
{
    [SerializeField] private int _Damage;
   

    

    private void OnTriggerEnter(Collider other)
    {
        
        PlayerMod playerMod = other.attachedRigidbody.GetComponent<PlayerMod>();
        if (playerMod)
        {

            playerMod.HitBarier(_Damage);
            Destroy(gameObject);
        }
    }
}
