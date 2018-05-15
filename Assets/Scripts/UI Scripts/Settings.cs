using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public bool musicIsOff;
    public bool SFXIsOff;
    public Toggle[] toggles;
    private static Settings settingInstance;

    void Awake()
    {

        DontDestroyOnLoad(gameObject);
        if (settingInstance == null)
        {
            settingInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }

    }
    void Start()
    {
        toggles = FindObjectsOfType<Toggle>();
    }
    public void MainMenu_Settings_MusicOFF()
    {
        if (musicIsOff)
        {
            musicIsOff = false;
        }
        else
        {
            musicIsOff = true;

        }

    }
    public void MainMenu_Settings_SFXOFF()
    {
        if (SFXIsOff)
        {
            SFXIsOff = false;
        }
        else
        {

            SFXIsOff = true;
        }
        
       
    }
   

}
