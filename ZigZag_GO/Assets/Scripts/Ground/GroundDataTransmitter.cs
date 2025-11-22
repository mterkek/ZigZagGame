using System.Collections;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;

    // Ground'un Rigidbody ayarlarını değiştiren wrapper metot
    public void SetGroundRigidbodyFall()
    {
        // GroundFallController içindeki coroutine’i çalıştırıyoruz
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }

    // Top ground'dan ayrıldığında tetiklenecek
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            SetGroundRigidbodyFall();
        }
    }
}
