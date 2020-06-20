using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour, IInteractable
{
    public UnityEvent onButtonClicked;

    public void Interact()
    {
        onButtonClicked.Invoke();
    }
}
