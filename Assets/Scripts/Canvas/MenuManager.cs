using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;

    public void StartGame()
    {
        SystemHealthPlayer._isAlive = true;
        TimeCounter._timer = 0;
        SystemHealthEnemy._numberKilledEnemies = 0;
        SceneManager.LoadScene(NamesScenes.GameScene);
        Time.timeScale = 1.0f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenSettingsPanel()
    {
        _settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        _settingsPanel.SetActive(false);
    }
}
