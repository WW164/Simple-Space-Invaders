using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : Shape
{
    public Vector2 projectileDirection;
    public float projectileSpeed;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        projectileDirection = Vector2.up;
        projectileSpeed = 2;

        //float red = Random.Range(0, 255);
        float blue = Random.Range(0, 255);
        float green = Random.Range(0, 255);

        SetColor(0, green, blue);
    }

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(projectileDirection * Time.deltaTime * projectileSpeed, Space.World);

        float top = transform.position.y + halfHeight;

        if (top >= screenBounds.y)
            Destroy(gameObject);
    }
}
