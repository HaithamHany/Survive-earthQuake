using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {


 

   
    public void MainMenu_Play()
    {

        SceneManager.LoadScene(1);

    }
    public void MainMenu_Settings()
    {
        SceneManager.LoadScene(2);

    }
    public void MainMenu_Exit()
    {
        Application.Quit();

    }
    public void MainMenu_Settings_back()
    {
        SceneManager.LoadScene(0);

    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
