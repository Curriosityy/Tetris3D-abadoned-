﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartRotator : MonoBehaviour
{
    bool isInitialized = false;


    // Start is called before the first frame update

    public void Initialize(Vector3 pos)
    {
        isInitialized = true;
    }

    
    private bool IsNewPositionInBoard(Vector3 newPosition)
    {
        return newPosition.x >= 0 && newPosition.x < GameManager.x && newPosition.y >= 0 && newPosition.y < GameManager.y+4 && newPosition.z >= 0 && newPosition.z < GameManager.z;
    }
    private bool IsNewPositionSocketEmpty(Vector3 newPosition)
    {
        Socket socket = FindObjectOfType<BoardCreator>().SocketLayers[(int)newPosition.y][(int)newPosition.x, (int)newPosition.z];
        if(socket.TetrisPart==null)
        {
            return true;
        }
        if(socket.TetrisPart==gameObject || socket.TetrisPart.transform.parent==gameObject.transform.parent)
        {
            return true;
        }
        return false;
    }
    public bool IsRotationPosible(Socket rootSocket)
    {

        return false;
    }
    private void OnDisable()
    {
        isInitialized = false;
    }
}
