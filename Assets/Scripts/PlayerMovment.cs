using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour {

    public float speed;
    public Vector3 dirction;
    private Animator anim;
    private bool rotateLeft;
    private bool rotateForward;
    public GameObject smokePrefab;
    public GameObject smokeScourcePosition;
    public AudioClip[]CarSound;
    private AudioSource Audio;
    private ScoreManager ScoreUpdate;
    public bool CanClick;
    public GameObject EarthquakeText;
	void Start () {

        CanClick = true;
        dirction = Vector3.zero;
        anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
        ScoreUpdate = FindObjectOfType<ScoreManager>();
        

    }

	void Update () {
       
        if (Input.GetMouseButtonDown(0) && CanClick)
        {
            if (dirction == Vector3.back)
            {
                dirction = Vector3.right;
                rotateLeft = true;
                rotateForward = false;
                produceSmoke();
                PlaycarSkiddingSFX();
                ScoreUpdate.score += 1;

                EarthquakeText.SetActive(false);
            }
            else
            {
                
                rotateForward = true;
                rotateLeft = false;
                dirction = Vector3.back;
                produceSmoke();
                PlaycarSkiddingSFX();
                ScoreUpdate.score += 1;
                EarthquakeText.SetActive(false);
            }

        }

        float amountToMove = speed * Time.deltaTime;
        transform.Translate(dirction * amountToMove);
       
            UpdateAnimator();
       
	}

    void produceSmoke()
    {
        GameObject Smoke = Instantiate(smokePrefab, smokeScourcePosition.transform.position, Quaternion.identity) as GameObject;
        Destroy(Smoke, 2);

    }
    void UpdateAnimator()
    {
        anim.SetBool("RotateLeft", rotateLeft);
        anim.SetBool("RotateRight", rotateForward);

    }

    void PlaycarSkiddingSFX()
    {
        Audio.clip = CarSound[0];
        Audio.Play();
    }
    void PlayEngineSFX()
    {
        Audio.clip = CarSound[1];
        Audio.Play();

    }
   
    
    
}
