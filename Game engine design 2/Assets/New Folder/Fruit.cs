using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Fruit : MonoBehaviour
{
    public GameManager manager;

    public abstract void GiveFruit();

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GiveFruit();
            Destroy(gameObject);
        }
    }
}
