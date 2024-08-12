using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 3;
    [SerializeField] private float _barrierDistance = 1;
    private Rigidbody2D _rb;
    private Vector2 _direction;
    private float _distanceBetweenPlayer;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        _direction = _target.position - transform.position;
        _direction.Normalize();
        _distanceBetweenPlayer = Vector2.Distance(transform.position, _target.position);
    }
    private void FixedUpdate()
    {
        if (_distanceBetweenPlayer > _barrierDistance)
        {
            MoveEnemy(_direction);
        }
    }

    private void MoveEnemy(Vector2 direction)
    {
        Vector2 nextPosition = direction * (_speed * Time.fixedDeltaTime);
        _rb.MovePosition(_rb.position + nextPosition);
    }
}
