using System.Collections;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;

    // RigidBody'li bir obje bu collider'dan ayrıldığında çağrılır
    private void OnCollisionExit(Collision collision)
    {
        // Çarpışmadan çıkan obje "Ball" tag'ine sahip mi?
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Ground'un rigidbody ayarlarını değiştir (düşmesini başlat)
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
}