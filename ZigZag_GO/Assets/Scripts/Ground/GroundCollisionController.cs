using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;

    public void CollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyFall();
        }
    }

}
