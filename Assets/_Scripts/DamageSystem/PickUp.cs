using UnityEngine;

public class PickUp : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        Absorption(other);
    }

    protected virtual void Absorption(Collider other)
    {

    }
}
