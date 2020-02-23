using UnityEngine;

public class end_trigger : MonoBehaviour
{
	//public int laps = 3;
	//public int onLap = 0;
	public GameManager gameMan;
	//public Canvas canvas;
	public lapCounter lapCounter;
	public lapCounter lapCounter2;
	public Score timer;
	public Score timer2;
	public PlayerController p1;
	public PlayerController p2;
	public bool p1Finished;
	public bool p2Finished;
	// Start is called before the first frame update
	void OnTriggerEnter(Collider target)
	{
		//gameMan = GetComponent<GameManager>();

		//canvas = GetComponent<Canvas>();
		if (target.tag == "p1")
		{
			p1Finished = lapCounter.AddLap();
			Debug.Log(p1Finished);
			//p1.TakeDmg(1);
			timer.Reset();
		}
		else if(target.tag == "p2")
		{
			p2Finished = lapCounter2.AddLap();
			Debug.Log(p2Finished);
			//p2.TakeDmg(1);
			timer2.Reset();
		}
		if (p1Finished)
		{
			gameMan.BlueWins();
		}
		else if (p2Finished) 
		{
			gameMan.RedWins();
		}
	}
}
