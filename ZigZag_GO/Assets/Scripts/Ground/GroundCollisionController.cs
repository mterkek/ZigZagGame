using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
}
