using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
        // Moves the player to the spawn point
        player.transform.position = respawnPoint.transform.position;
	}
}
