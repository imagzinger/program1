using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	//public Transform player;
	public Text scoreText;
	float lap_stop = 0.0f;


	void Update()
    {
		scoreText.text = ((int)(Time.time - lap_stop)).ToString();
    }

	public void Reset()
	{
		lap_stop = Time.time;

	}
}

