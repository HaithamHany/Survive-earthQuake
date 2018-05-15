using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject BgMusic;
    [SerializeField]
    private GameObject SFXMusic;
    private Settings SetMenu;
    public AudioSource CarSound;

    // Update is called once per frame
   
    void Start()
    {

        SetMenu = FindObjectOfType<Settings>();

    }
	void Update () {
       
      if (SetMenu.musicIsOff)
        {
            
            BgMusic.SetActive(false);

        }
       else
        {
            BgMusic.SetActive(true);
           

        }
       if (SetMenu.SFXIsOff)
        {

            SFXMusic.SetActive(false);
            CarSound.mute = true;
           
        }
        else
        {

            SFXMusic.SetActive(true);
            CarSound.mute= false;
           
        }

	}
}
