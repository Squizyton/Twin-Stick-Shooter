using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonBuilder : MonoBehaviour
{
    public DungeonTileSet tileSet;
    
    //How Many rooms do we want?
    public int numberOfCells;

    public GameObject startingRoom;
    private GameObject startingroomSpawn;
    
    void Start()
    {
        Intialize();
    }


    void Intialize()
    {
        //TODO: Randomize a starting room;
        startingroomSpawn = Instantiate(startingRoom, transform.position, transform.rotation);
        
        GenerateDungeon();
    }

    void GenerateDungeon()
    {
        var startingPoint = startingroomSpawn.GetComponentsInChildren<ConnectionPoint>();
        Debug.Log(startingPoint.Length);
        var number = Random.Range(0, startingPoint.Length);
        var pickedPoint = startingPoint[number];
        startingPoint[number] = null;

        for (int x = 0; x < numberOfCells; x++)
        {
            var randomRoomNum = Random.Range(0, tileSet.tiles.Count);
            var pickedRoom = tileSet.tiles[randomRoomNum];

            var spawnedRoom = Instantiate(pickedRoom.prefab, transform.position, new Quaternion(0f, pickedPoint.connectorRotation, 0f,0f));

            var whichPoint = spawnedRoom.GetComponentsInChildren<ConnectionPoint>();
            

        }
    }
}
