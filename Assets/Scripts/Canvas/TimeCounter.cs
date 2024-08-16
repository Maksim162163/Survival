using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public static float Timer;
    private float _minutes;
    private float _seconds;
    [SerializeField] private TextMeshProUGUI _timeText;

    private void Start()
    {
        Timer = 0;
        _minutes = 0;
        _seconds = 0;
    }

    private void Update()
    {
        if (SystemHealthPlayer._isAlive)
        {
            Timer += Time.deltaTime;
            DisplayTime(Timer);
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        _seconds = Mathf.FloorToInt(Timer % 60);
        _minutes = Mathf.FloorToInt(Timer / 60);

        _timeText.text = string.Format("Time: {0:00}:{1:00}", _minutes, _seconds);
    }
}
