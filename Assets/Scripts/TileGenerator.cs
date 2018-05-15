using UnityEngine;
using System.Collections;

public class TileGenerator : MonoBehaviour {

    private TileManager TManager;
    private Rigidbody rb;
    private float fallDelay = 1f;
	void Start () {

        rb = GetComponent<Rigidbody>();
        TManager = FindObjectOfType<TileManager>();
	
	}
	

    void OnTriggerEnter(Collider coll)
    {
    
        if (coll.gameObject.tag == "Player")
        {
            
            TManager.SpawnTile();
            StartCoroutine(FallDown());
           

        }


    }
    void OnTriggerExit(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {

            Destroy(gameObject, 2);
           
        }

    }

    IEnumerator FallDown()
    {

        yield return new WaitForSeconds(fallDelay);
        rb.isKinematic= false;
  
    }
}
