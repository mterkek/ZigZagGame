using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private GameObject lastGroundObject;

    private int groundDirection;

    public void SpawnGround()
    {
        CreateNewGround();

        for (int i = 0; i < 90; i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2);
        Vector3 newPosition;

        if (groundDirection == 0)
        {
            newPosition = lastGroundObject.transform.position + new Vector3(-1f, 0, 0);
        }
        else
        {
            newPosition = lastGroundObject.transform.position + new Vector3(0, 0, 1f);
        }

        GameObject newGroundObject = Instantiate(groundPrefab, newPosition, Quaternion.identity);
        lastGroundObject = newGroundObject;
    }
}
