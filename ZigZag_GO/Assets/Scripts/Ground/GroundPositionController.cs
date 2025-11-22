using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    //private GroundFallController groundFallController;
    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;
    [SerializeField] private float endYposition ;
    
    
    private int groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType <GroundSpawnController>();

        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        CheckGroundPositionVertical();
    }
    private void CheckGroundPositionVertical()
    {
        if (transform.position.y < endYposition)
        {
                SetRigidbodyValues();

              SetGroundNewPosition();
        }
    }
    
    private void SetGroundNewPosition()
    {
          groundDirection = Random.Range(0, 2);
            
            if (groundDirection == 0)
            {
             transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z);    
            }
            else
            {
             transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x , groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z + 1f);    
            }
            groundSpawnController.lastGroundObject = gameObject;
    }
    private void SetRigidbodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
