using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();   
    }
    public void OpenDoor()
    {
        doorAnimator.Play("Sliding");
    }
}
