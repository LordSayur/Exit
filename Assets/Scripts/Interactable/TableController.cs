using UnityEngine;

public class TableController : MonoBehaviour, IInteractable
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Interact()
    {
        if (transform.parent is null)
        {
            transform.SetParent(player);
        }
        else
        {
            transform.parent = null;
        }

    }
}
