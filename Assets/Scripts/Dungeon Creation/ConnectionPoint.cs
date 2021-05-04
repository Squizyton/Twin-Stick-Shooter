using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionPoint : MonoBehaviour
{
   public bool isConnected;

   public int connectorRotation;

   public ConnectionType connectionType;
   public ConnectionType connectedTo = ConnectionType.Nothing;
   
   
}
