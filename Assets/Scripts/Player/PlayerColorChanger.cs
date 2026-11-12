using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += TargetDestroyedHandler;
    }

    void TargetDestroyedHandler(GameItem gameItem)
    {
        if (gameItem == GameItem.Gem)
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.red;
            }
        }
        else if (gameItem == GameItem.Key)
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
