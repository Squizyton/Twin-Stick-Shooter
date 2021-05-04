using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ConnectionType
{
    Nothing,
    Hallway,
    Room,
    Staircase,
    BossRoom
}

[CreateAssetMenu(fileName = "New Tile" ,menuName = "Dungeon/Tile")]
public class Tile : ScriptableObject
{
    public enum BuildPoints
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }
    
    public List<BuildPoints> buildPoints = new List<BuildPoints>();
    public GameObject prefab;
}
