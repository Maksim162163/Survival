using TMPro;
using UnityEngine;

public class CounterKilledEnemies : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textKilledEnemies;

    private void Update()
    {
        DisplayKilledEnemies();
    }

    private void DisplayKilledEnemies()
    {
        _textKilledEnemies.text = string.Format("Killed enemies: {0}", 
            SystemHealthEnemy._numberKilledEnemies);
    }
}
