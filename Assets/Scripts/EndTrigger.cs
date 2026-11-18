using UnityEngine;

public class EndTrigger : MonoBehaviour
{

[SerializeField] private GameManager gameManagerScript;
	private void OnTriggerEnter(Collider collider)
	{
	if(collider.CompareTag("Player"))
		{
		Debug.Log("Level Won");
		gameManagerScript.CompleteLevel();
		}

	}



}
