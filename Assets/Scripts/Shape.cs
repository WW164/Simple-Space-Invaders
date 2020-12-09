using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public Vector3 screenBounds;

    protected float halfHeight;
    protected float halfWidth;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        halfHeight = spriteRenderer.bounds.extents.x;
        halfWidth = spriteRenderer.bounds.extents.y;

        screenBounds = GetScreenBounds();
    }

    public void SetColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }

    public void SetColor(float red, float green, float blue)
    {
        Color newColor = new Color(red, green, blue);
        spriteRenderer.color = newColor;
    }

    private Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;
        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }
}