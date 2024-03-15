using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    public Transform playerSpawnPoint;

    // Assign the reference in Awake or Start
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Call this method when the player exits the house
    public void PlayerExitedHouse()
    {
        if (playerSpawnPoint != null)
        {
            // Spawn the player at the spawn point near the door
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = playerSpawnPoint.position;
            }
            else
            {
                Debug.LogError("Player not found in the scene.");
            }
        }
        else
        {
            Debug.LogError("Player spawn point is not assigned.");
        }
    }
}
