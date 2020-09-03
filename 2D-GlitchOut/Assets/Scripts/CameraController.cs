using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Variables
    public Transform player;

    [Space]
    [Header("Input Settings:")]
    public float smoothing;
    public Vector2 minBoundary;
    public Vector2 maxBoundary;
#endregion
#region Methods
    void Update()
    {
        Vector3 playerPos = new Vector3(player.position.x, player.position.y, transform.position.z);

        playerPos.x = Mathf.Clamp(player.position.x, minBoundary.x, maxBoundary.x);
        playerPos.y = Mathf.Clamp(player.position.y, minBoundary.y, maxBoundary.y); 

        transform.position = Vector3.Lerp(transform.position, playerPos, smoothing);
    }
    #endregion
}
