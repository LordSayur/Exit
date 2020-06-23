using UnityEngine;

public class InspectObject : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 180f;

    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, rotationSpeed * -1 * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(gameObject);
        }
    }
}
