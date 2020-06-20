using UnityEngine;

public class PlayerObjectDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable Object")
        {
            other.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable Object")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                other.GetComponent<IInteractable>().Interact();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable Object")
        {
            other.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
}
