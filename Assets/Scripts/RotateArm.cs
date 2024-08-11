using UnityEngine;

[RequireComponent(typeof(MouseInput))]
public class RotateArm : MonoBehaviour
{
    [SerializeField] private MouseInput _mouseInput;
    public float angleRotationZ;
    
    private void Update()
    {
        Rotate(_mouseInput.MousePosition());
    }

    private void Rotate(Vector2 target)
    {
        angleRotationZ = _mouseInput.GetAngleRotationZ(target);

        transform.rotation = Quaternion.Euler(0, 0, angleRotationZ);

        Flip();
    }

    private void Flip()
    {
        Vector3 localScale = Vector3.one;

        if (angleRotationZ > 90 || angleRotationZ < -90)
            localScale.y = -1f;
        else
            localScale.y = +1f;

        transform.localScale = localScale;
    }
}
