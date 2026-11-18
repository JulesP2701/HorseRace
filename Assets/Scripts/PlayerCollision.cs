using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] private PlayerMovement playerMovementScript;
	void OnCollisionEnter(Collision collisionInfo)
	{
	if(collisionInfo.collider.CompareTag("Obstacle"))
		{
			Debug.Log("On a touché + " + collisionInfo.collider.name + "!");
			playerMovementScript.enabled = false;
		}
		
		
	}




}
