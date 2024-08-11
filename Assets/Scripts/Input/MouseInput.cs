using UnityEngine;

public class MouseInput : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    public Vector2 MousePosition()
    {
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        return mousePosition;
    }

    public float GetAngleRotationZ(Vector2 target)
    {
        Vector2 lookDirection = target - (Vector2)transform.position;
        float angleRotationZ = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        return angleRotationZ;
    }
}
