using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyed : MonoBehaviour
{
    [SerializeField] private GameEvent onDestroyedObjects;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Enemy Destroyed");

        Destroy(gameObject);
        Destroy(collision.gameObject);

        onDestroyedObjects.Raise();
    }
}
