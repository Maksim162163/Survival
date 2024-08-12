using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RotateEnemy : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private SpriteRenderer _sr;

    private void Awake()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        FlipPlayer(_target.position);
    }

    public void FlipPlayer(Vector2 target)
    {
        if (transform.position.x > target.x)
            _sr.flipX = false;
        else
            _sr.flipX = true;
    }
}
