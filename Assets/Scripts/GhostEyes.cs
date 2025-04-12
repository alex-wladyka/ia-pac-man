using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GhostEyes : MonoBehaviour
{
    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;

    public SpriteRenderer spriteRenderer { get; private set; }
    public CharacterPathfindingMovementHandler movement { get; private set; }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<CharacterPathfindingMovementHandler>();
    }

    private void Update()
    {
        if (movement.moveDir.y > 0.5) {
            spriteRenderer.sprite = up;
        }
        else if (movement.moveDir.y < -0.5) {
            spriteRenderer.sprite = down;
        }
        else if (movement.moveDir.x < -0.5) {
            spriteRenderer.sprite = left;
        }
        else if (movement.moveDir.x > 0.5) {
            spriteRenderer.sprite = right;
        }
    }

}
