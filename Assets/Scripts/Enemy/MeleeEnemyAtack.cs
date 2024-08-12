using UnityEngine;

public class MeleeEnemyAtack : MonoBehaviour
{
    [SerializeField] private float _attackRate;
    [SerializeField] private int _damage;
    private float _timerBetweenAttack;
    private SystemHealthPlayer _systemHealthPlayer;

    private void Start()
    {
        _timerBetweenAttack = 0f;
    }

    private void Update()
    {
        if (_timerBetweenAttack > 0f)
            _timerBetweenAttack -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _systemHealthPlayer = collision.GetComponent<SystemHealthPlayer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_systemHealthPlayer != null && _timerBetweenAttack <= 0)
        {
            _systemHealthPlayer.TakeDamage(_damage);
            _timerBetweenAttack = _attackRate;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<SystemHealthPlayer>() != null)
        {
            _systemHealthPlayer = null;
        }
    }
}
