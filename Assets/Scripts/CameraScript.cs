using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {



    private PlayerMovment player;
    public GameObject DeathMenu;
    public Transform playerToFollow;
    private ShakeCamera mainCamera;
    public float X_Offset,y_Offset,Z_Offset;


    void Start()
    {
       
        player = FindObjectOfType<PlayerMovment>();
        DeathMenu.SetActive(false);
        mainCamera = FindObjectOfType<ShakeCamera>();
        
    }

    void Update () {

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        if (mainCamera.shakeCamera)
        {

            mainCamera.ShakeMainCamera();

        }
        if (playerToFollow.transform.position.y < 2.7f)
        {
            Debug.Log("out of border");
            player.CanClick = false;
            playerToFollow = null;
            mainCamera.shakeCamera = false;
            DeathMenu.SetActive(true);

        }
        else
        {
            mainCamera.shakeCamera = true;
            transform.position = new Vector3(playerToFollow.position.x+X_Offset, playerToFollow.position.y+y_Offset, playerToFollow.position.z+Z_Offset);
        }
	
	}

    
}
