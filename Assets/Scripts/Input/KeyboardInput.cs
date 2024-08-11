using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _physicsMovement;
    [SerializeField] private GameObject _pausePanel;

    private Vector2 _directionMovement;

    private void Update()
    {
        float _directionAxisX = Input.GetAxisRaw(Axis.Horizontal);
        float _directionAxisY = Input.GetAxisRaw(Axis.Vertical);

        _directionMovement = new Vector2(_directionAxisX, _directionAxisY);

        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0.0f;
            _pausePanel.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        _physicsMovement.Move(_directionMovement);
    }
}
