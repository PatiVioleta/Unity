using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 4f;
    public GameObject completeGameUI;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvasRate;
    public GameObject player;

    public PauseMenu pm;

    public int levelToUnlock = 2;
    public LevelSelector levSel;

    public void Start()
    {
        if(PlayerPrefs.GetInt("rate", 0)%3 == 0 && canvasRate!=null)
        {
            canvas1.SetActive(false);
            canvasRate.SetActive(true);
        }
    }

    public void completeLevel()
    {
        if(levelToUnlock<11 && levelToUnlock>PlayerPrefs.GetInt("levelReached",1) )
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        if (player != null)
            Destroy(player);
        canvas1.SetActive(false);
        completeGameUI.SetActive(true);
    }

    public void EndGame()
    {
        if ( gameHasEnded== false)
        {
            gameHasEnded = true;
            /*
            if (PlayerPrefs.GetInt("end", 0) %5 ==0)
            {
                ShowAds();
                if(pm!=null)
                    pm.Pause();
            }*/
                
            PlayerPrefs.SetInt("end", PlayerPrefs.GetInt("end", 0) + 1);
            
            Invoke("Restart", restartDelay);
            
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ChangeToScene( int SceneToChangeTo)
    {
        SceneManager.LoadScene(SceneToChangeTo);
    }

    public void ChangeCanvas()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }

    public void ChangeCanvasReverse()
    {
        canvas2.SetActive(false);
        canvas1.SetActive(true);
    }

    public void ChangeCanvasFromRate()
    {
        canvasRate.SetActive(false);
        canvas1.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void RestartGame()
    {
        PlayerPrefs.SetInt("levelReached", 1);
        levSel.Start();
    }

    public void ShowAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public void GooglePlay()
    {
        ChangeCanvasFromRate();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.PatiGames.Breakable");
    }
}
