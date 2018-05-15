using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {


   public  void restart()
    {

        SceneManager.LoadScene(1);

    }
    public void Exit()
    {

        SceneManager.LoadScene(0);

    }
}
