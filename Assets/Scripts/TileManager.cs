using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {


   // public GameObject leftTilePrefab;
   // public GameObject topTilePrefab;
    public GameObject currentTile;
    public GameObject[] tilePrefabs;
    public int numberOfStartingTiles=25;

 



    // Use this for initialization
    private void Start () {
        
        
        for (int i = 0; i < numberOfStartingTiles; i++)
        {
            SpawnTile();
     
        }

    }
	

    public void SpawnTile()
    {
        int tileNumber = Random.Range(0, 2);
        currentTile = Instantiate(tilePrefabs[tileNumber], currentTile.transform.GetChild(0).transform.GetChild(tileNumber).transform.position, Quaternion.identity) as GameObject;
        
    }
   

}
