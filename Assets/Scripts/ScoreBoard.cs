using UnityEngine;
using TMPro;


public class ScoreBoard : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform playerTransform;


	// Update is called once per frame
	void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");  
	}
}
