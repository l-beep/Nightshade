using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player player;

    private void Update()
    {
        transform.Translate(Vector2.right * player.movespeed * Time.deltaTime);
    }
}
