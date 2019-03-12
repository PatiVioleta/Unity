using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    public Button restartButton;
    public Toggle toggle;
    public ForSound FS;

    public void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        //PlayerPrefs.SetInt("levelReached", 10);
        PlayerPrefs.GetInt("end", 0);
        PlayerPrefs.GetInt("rate", 0);
        PlayerPrefs.SetInt("rate", PlayerPrefs.GetInt("rate", 0) + 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i+1 > levelReached)
                levelButtons[i].interactable = false;
        }

        if (levelReached == 1)
            restartButton.interactable = false;
    }

    void Awake()
    {
        FS.MakeFalse();

        if (PlayerPrefs.GetInt("Sound", 2) == 1)
        {
            toggle.isOn = false;
        }
    }
}
