using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public CameraController cameraa;
    public PlayerController player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*Basically stops the camera from following the player after death.
         * and also kills the game object
         */

        cameraa.followPlayer = false;
        player.GameOver();
    }
}
