using System.Collections;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;
    [SerializeField] private GroundCollisionController groundCollisionController;
    // GroundCollisionController burayı çağırır
    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
        StartCoroutine(groundCollisionController.WaitAndDisableCollider());
    }
}
