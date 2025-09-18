using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public abstract class Fruit : MonoBehaviour
{
    protected GameManager manager;

    public abstract void GiveFruit();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GiveFruit();
            Destroy(gameObject);
        }
    }

    protected void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
    }
}
