using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientFunctions : MonoBehaviour
{

    static public void ClientConsoleWrite(string message)
    {
        Debug.LogWarning(message);
    }
}
