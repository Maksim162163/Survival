using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _losePanel;

    public void GoMenu()
    {
        _losePanel.SetActive(false);
        SceneManager.LoadScene(NamesScenes.MenuScene);
        Time.timeScale = 0.0f;
        SystemHealthPlayer._isAlive = false;
        TimeCounter._timer = 0;
        SystemHealthEnemy._numberKilledEnemies = 0;
    }

    public void ContinueGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void RestartGame()
    {
        _losePanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
        SystemHealthPlayer._isAlive = true;
        TimeCounter._timer = 0;
        SystemHealthEnemy._numberKilledEnemies = 0;
    }
}
