using UnityEngine;

public class ForSound : MonoBehaviour
{
    static bool mute = false;

    public void ChangeSound()
    {
        mute = !mute;
        if (mute == true)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }
            
        else
        {
            PlayerPrefs.SetInt("Sound", 2);
        }
            
    }

    public bool GetSound()
    {
        return mute;
    }

    public void MakeFalse()
    {
        mute = false;
    }
}
