using System;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;


    public class setGroundRigidbodyFall
    {
        [SerializeField] private IEnumerator groundFallController;
    }

    public void SetGroundRigidbodyValues()
    {
       StartCoroutine(groundFallController.SetRigidbodyValues());
    }
}
