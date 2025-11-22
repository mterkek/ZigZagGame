using System.Collections;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValues()
    {
        // Biraz bekle, sonra ground'u düşür
        yield return new WaitForSeconds(0.7f);

        rb.isKinematic = false;
        rb.useGravity = true;
    }
}