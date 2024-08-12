using UnityEngine;

public class SystemHealthPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private int _healthRegeneration = 40;
    [SerializeField] private float _rateHealthRegeneration = 5f;
    [SerializeField] private int _maxHealth = 100;
    private int _health;
    private float _remainingRegenerationTime;
    private FloatingHealthBar _healthBar;
    public static bool _isAlive = true;
    private bool _isDamaged = false;

    private void Start()
    {
        _health = _maxHealth;
        _remainingRegenerationTime = _rateHealthRegeneration;
        _healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void Update()
    {
        if (_remainingRegenerationTime <= 0)
        {
            if (_health < _maxHealth)
            {
                _health += _healthRegeneration;
                if (_health >= _maxHealth)
                {
                    _health = _maxHealth;
                    _isDamaged = false;
                }
                _remainingRegenerationTime = _rateHealthRegeneration;
            }
        }
        if (_isDamaged)
        {
            _remainingRegenerationTime -= Time.deltaTime;
        }

        _healthBar.UpdateHealthBar(_health, _maxHealth);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        _isDamaged = true;

        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Time.timeScale = 0.0f;
        Destroy(gameObject);
        _isAlive = false;
        if (_losePanel != null)
        {
            _losePanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}