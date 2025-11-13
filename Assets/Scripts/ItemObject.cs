using UnityEngine;
public interface IInteractable
{
    public string GetInteractPrompt();
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}";
        return str;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"[ItemObject] Trigger entered by {other.name}");

        PlayerCondition player = other.GetComponent<PlayerCondition>();
        if (player == null)
        {
            Debug.Log("[ItemObject] PlayerCondition not found on collided object.");
            return;
        }

        if (data == null)
        {
            Debug.LogWarning("[ItemObject] No ItemData assigned.");
            return;
        }

        data.ApplyEffect(player);
        Debug.Log($"[ItemObject] Applied {data.displayName} to {player.name}");
        Destroy(gameObject);
    }
    
}
