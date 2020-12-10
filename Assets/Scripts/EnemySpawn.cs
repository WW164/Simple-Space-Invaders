using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public EnemyMovement enemyPrefab;
    public Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = GetScreenBounds();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies ()
    {
        for(int i = 0; i < 100; i++)
        {
            WaitForSeconds wait = new WaitForSeconds(2);

            float horizontalPosition = Random.Range(-screenBounds.x, screenBounds.x);
            Vector2 spawnPosition = new Vector2(horizontalPosition, screenBounds.y);

            EnemyMovement enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            yield return wait;
        }
    }

    private Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;
        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }
}
