using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text DriftsText;
    public Text DeathMenuScore;
    public Text BestScore;
    public int score = 0;
    public static GameObject Instance;

    
	// Update is called once per frame
	void Update () {
        
        DriftsText.text = "Drifts: " + score;
        DeathMenuScore.text = DriftsText.text;
        

        
        
	}
}
