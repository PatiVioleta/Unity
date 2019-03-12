using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject pauseButtUi;

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseButtUi.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        pauseButtUi.SetActive(false);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(11);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }
}
