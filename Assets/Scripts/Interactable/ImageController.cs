using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour, IInteractable
{
    [SerializeField]
    private GameObject imagePrefab;
    private Camera camera;

    void Start()
    {
        camera = FindObjectOfType<Camera>();
    }

    void Update()
    {
        
    }
    public void Interact()
    {
        var image = Instantiate(imagePrefab, camera.transform.position, Quaternion.identity);
        image.transform.SetParent(camera.transform);
        image.transform.localPosition = new Vector3(0, 0, 4);
        image.AddComponent<InspectObject>();
    }
}
