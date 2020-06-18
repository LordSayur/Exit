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

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable Object")
        {
            other.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
}
