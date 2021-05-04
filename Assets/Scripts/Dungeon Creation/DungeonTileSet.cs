using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tile Set", menuName = "Dungeon/New Tile Set")]
public class DungeonTileSet : ScriptableObject
{
    //Currently set as list
    public List<Tile> tiles = new List<Tile>();

}
