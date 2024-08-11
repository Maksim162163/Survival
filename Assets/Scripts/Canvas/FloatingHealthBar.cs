using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    private Canvas _canvasHealthBar;

    private void Start()
    {
        _canvasHealthBar = GetComponentInParent<Canvas>();
        _canvasHealthBar.enabled = false;
    }

    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
         _healthBar.value = currentHealth / maxHealth;
        if (_healthBar.value < 1)
        {
            _canvasHealthBar.enabled = true;
        }
        else
        {
            _canvasHealthBar.enabled = false;
        }
    }

    private void Update()
    {
        transform.rotation = _camera.transform.rotation;
        transform.position = _target.position + _offset;
    }
}
