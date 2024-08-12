using UnityEngine;

public class SystemHealthEnemy : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    public static int _numberKilledEnemies = 0;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
        _numberKilledEnemies++;
    }
}