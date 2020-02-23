using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	//public PlayerMovement movement;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
		if (collisionInfo.collider.tag == "obstacle")
		{
			Debug.Log(collisionInfo.collider.name);
			GetComponent<PlayerMovement>().enabled = false;
			GameObject.FindObjectOfType<GameManager>().EndGame();
		}
		if (collisionInfo.collider.tag == "end")
		{
			Debug.Log(collisionInfo.collider.name);
			GetComponent<PlayerMovement>().enabled = false;
			GameObject.FindObjectOfType<GameManager>().CompleteLevel();
		}
	}
}
