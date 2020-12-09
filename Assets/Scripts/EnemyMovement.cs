using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Shape
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }
    private void MoveEnemy()
    {
        transform.Translate(Vector2.down * Time.deltaTime, Space.World);

        float bottom = transform.position.y - halfHeight;

        if (bottom <= -screenBounds.y)
            Destroy(gameObject);
    }
}
