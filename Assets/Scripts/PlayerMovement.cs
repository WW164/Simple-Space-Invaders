using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Shape
{
    public ScreenBoundManager screenBoundManager;
    public float playerSpeed;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        screenBoundManager = FindObjectOfType<ScreenBoundManager>();
        playerSpeed = 0.1f;
        SetColor(Color.yellow);   
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontalMovement) > Mathf.Epsilon)
        {
            horizontalMovement += horizontalMovement * Time.deltaTime * playerSpeed;
            horizontalMovement += transform.position.x;

            float right = screenBoundManager.screenBounds.x;
            float left = -right;

            float limit =
                Mathf.Clamp(horizontalMovement, left, right);

            transform.position = new Vector2(limit, transform.position.y);
        }
    }
}