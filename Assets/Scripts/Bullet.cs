using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _hitEffect;
    [SerializeField] private int _damage = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SystemHealthEnemy systemHealthEnemy = collision.GetComponent<SystemHealthEnemy>();
        if (systemHealthEnemy != null)
        {
            systemHealthEnemy.TakeDamage(_damage);
        }
    }
}
