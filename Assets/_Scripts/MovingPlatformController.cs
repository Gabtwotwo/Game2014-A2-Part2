using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public bool isActive;
    public float platformTimer;
    public PlayerBehaviour playerRef;


    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        platformTimer = 0;
        isActive = false;
        distance = end.position - start.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            platformTimer += 0.02f;
            _Move();

        }
        if(playerRef.resetPlatforms == true)
        {
            playerRef.resetPlatforms = false;
            transform.position = start.position;
        }

    }


    private void _Move()
    {

        var distanceX = (distance.x > 0) ? start.position.x + Mathf.PingPong(platformTimer, distance.x) : start.position.x;
        var distanceY = (distance.y > 0) ? start.position.y + Mathf.PingPong(platformTimer, distance.y) : start.position.y;

        transform.position = new Vector3(distanceX, distanceY, 0.0f);
    }
}
