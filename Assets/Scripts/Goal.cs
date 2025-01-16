using UnityEngine;

public class Goal : MonoBehaviour
{
    const string PlayerTag = "Player";
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            Destroy(gameObject);
        }
    }
}
