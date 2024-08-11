using UnityEngine;

[RequireComponent(typeof(MouseInput))]
[RequireComponent(typeof(SpriteRenderer))]
public class RotatePlayer : MonoBehaviour
{
    [SerializeField] private MouseInput _mouseInput;    
    private SpriteRenderer _sr;

    private void Awake()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        FlipPlayer(_mouseInput.MousePosition());
    }

    public void FlipPlayer(Vector2 mousePosition)
    {
        if (_mouseInput.GetAngleRotationZ(mousePosition) > 90 
            || _mouseInput.GetAngleRotationZ(mousePosition) < -90)
            _sr.flipX = false;
        else
            _sr.flipX = true;
    }
}
