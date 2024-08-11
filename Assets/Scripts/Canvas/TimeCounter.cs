using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public static float _timer;
    private float _minutes;
    private float _seconds;
    [SerializeField] private TextMeshProUGUI _timeText;

    private void Start()
    {
        _timer = 0;
        _minutes = 0;
        _seconds = 0;
    }

    private void Update()
    {
        if (SystemHealthPlayer._isAlive)
        {
            _timer += Time.deltaTime;
            DisplayTime(_timer);
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        _seconds = Mathf.FloorToInt(_timer % 60);
        _minutes = Mathf.FloorToInt(_timer / 60);

        _timeText.text = string.Format("Time: {0:00}:{1:00}", _minutes, _seconds);
    }
}
