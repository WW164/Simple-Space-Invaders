using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public ProjectileMovement projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            FireProjectile();
    }

    private void FireProjectile()
    {
        Vector2 spawnPosition = transform.position;

        ProjectileMovement projectileMovement =
            Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);
    }
}
