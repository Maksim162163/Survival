using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 directionMovement)
    {
        Vector2 offset = directionMovement.normalized * (_speed * Time.fixedDeltaTime);

        _rb.MovePosition(_rb.position + offset);
    }
}
