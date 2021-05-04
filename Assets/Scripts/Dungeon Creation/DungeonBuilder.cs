using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonBuilder : MonoBehaviour
{
    public DungeonTileSet tileSet;
    
    //How Many rooms do we want?
    public int numberOfCells;

    public GameObject startingRoom;
    
    
    void Start()
    {
        Intialize();
    }


    void Intialize()
    {
        //TODO: Randomize a starting room;
        Instantiate(startingRoom, transform.position, transform.rotation);
        
        GenerateDungeon();
    }

    void GenerateDungeon()
    {
        var previousRoom = 
        for (int x = 0; x < numberOfCells; x++)
        {
                   
        }
    }
}
