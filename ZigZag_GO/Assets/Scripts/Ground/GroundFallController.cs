using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    public IEnumerator SetRigidbodyValues()
    {
        yield return new WaitForSeconds(0.5f);
        rb.isKinematic = false;
        rb.useGravity = true;

    }
}
