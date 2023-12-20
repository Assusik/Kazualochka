using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (playerBehaviour)
        {
            playerBehaviour.StartPreFinishBehaviour();
        }
    }
}
