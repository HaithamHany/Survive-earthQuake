using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour {


    public float shakeTimer;
    public float shakeIntenisity = 0.1f;
    public bool shakeCamera;
    private float resetTime;
    private void Start () {
        resetTime = shakeTimer;
    }
	
	
    public void ShakeMainCamera()
    {

        //shakeIntenisity = shakePower;
        //shakeTimer = shakeDuration;
        if (shakeTimer >= 0)
        {
            Vector2 ShakePos = Random.insideUnitCircle * shakeIntenisity;
            transform.position = new Vector3(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y, transform.position.z);
            shakeTimer -= Time.deltaTime;
            if (shakeTimer < 0)
            {

                shakeCamera = false;
                shakeTimer = resetTime;
            }

        }

    }
}
