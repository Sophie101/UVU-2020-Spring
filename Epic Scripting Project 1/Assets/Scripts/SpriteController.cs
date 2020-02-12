using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.red;
    public Color offColor = Color.red;
    public SpriteRenderer spriteObj;

    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
        spriteObj.color = spriteColor;

    }

    private void OnEnable()
    {
        spriteObj.color = spriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = offColor;
    }

    void Update()
    {
        
    }
}
