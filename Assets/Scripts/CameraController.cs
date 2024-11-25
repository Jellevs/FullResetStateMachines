using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController CameraInstance;


    private void Awake()
    {
        CameraInstance = this;
    }

    public void SwitchPlayer(Transform player)
    {
        transform.parent = player;
        transform.localPosition = new Vector3(0, 4, -10);
    }
}

