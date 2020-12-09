using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected float halfHeight;
    protected float halfWidth;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        halfHeight = spriteRenderer.bounds.extents.x;
        halfWidth = spriteRenderer.bounds.extents.y;
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
}
