using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public float pause;
	public GameObject CompleteLevelUI;

	public void EndGame()
	{
		if (!gameHasEnded)
		{
			Debug.Log("GAME OVER");
			gameHasEnded = true;

			Invoke("Restart", pause);
		}

	}

	public void CompleteLevel()
	{
		//CompleteLevelUI.SetActive(true);
		//Invoke("next", pause);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void next()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void Respawn()
	{
		Restart();//filler for now
	}

	public void BlueWins()
	{
		SceneManager.LoadScene(3);
	}
	public void RedWins()
	{
		SceneManager.LoadScene(4);
	}

	public void Quit()
	{
		Application.Quit();
	}
	public void ToMainMenu()
	{
		SceneManager.LoadScene(0);
	}
}
