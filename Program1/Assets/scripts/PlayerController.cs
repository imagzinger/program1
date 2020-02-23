using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
	[SerializeField] Rigidbody rb;
	[SerializeField] Transform t;
	[SerializeField] Collider c;
	[SerializeField] GameManager gm;

    [SerializeField] static int maxHp = 3;

    [SerializeField] int hpLeft = maxHp;
    [SerializeField] bool living = true;
    [SerializeField] float rotSpeed = 60.0f;
    [SerializeField] float eulerAngY;
    [SerializeField] float z;
    [SerializeField] float x;
	[SerializeField] float force = 20.0f;
	[SerializeField] float dynaFric = 0.7f;
	[SerializeField] float statFric = 0.7f;
	[SerializeField] float degrees;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update() { 
		//eulerAngX = transform.localRotation.eulerAngles.x;
		eulerAngY = transform.localRotation.eulerAngles.y;
		//eulerAngZ = transform.localRotation.eulerAngles.z;// transform.localEulerAngles.z;
		degrees = transform.localRotation.eulerAngles.y;
		z = force* (float) Math.Cos((degrees-90) / 180 * Math.PI);
		x = force* (float) Math.Sin((degrees-90) / 180 * Math.PI);

		if (this.gameObject.tag == "p1") {
			if (Input.GetKey(KeyCode.W)){
				rb.AddForce(x * Time.deltaTime, 0, z * Time.deltaTime, ForceMode.VelocityChange);
			}
			if (Input.GetKey(KeyCode.S)){
				rb.AddForce(-x * Time.deltaTime, 0, -z * Time.deltaTime, ForceMode.VelocityChange);
			}
			if (Input.GetKey(KeyCode.D)){
				if (Input.GetKey(KeyCode.S))
				{
					degrees -= (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, -rotSpeed * Time.deltaTime);
				}
				else
				{
					degrees += (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, rotSpeed * Time.deltaTime);
				}
			}
			if (Input.GetKey(KeyCode.A)){
				if (Input.GetKey(KeyCode.S))
				{
					degrees += (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, rotSpeed * Time.deltaTime);
				}
				else
				{
					degrees -= (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, -rotSpeed * Time.deltaTime);
				}
			}

		}
		if (this.gameObject.tag == "p2") {
			if (Input.GetKey(KeyCode.UpArrow))
			{
				rb.AddForce(x * Time.deltaTime, 0, z * Time.deltaTime, ForceMode.VelocityChange);
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{
				rb.AddForce(-x * Time.deltaTime, 0, -z * Time.deltaTime, ForceMode.VelocityChange);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				if (Input.GetKey(KeyCode.DownArrow))
				{
					degrees -= (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, -rotSpeed * Time.deltaTime);
				}
				else
				{
					degrees += (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, rotSpeed * Time.deltaTime);
				}
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				if (Input.GetKey(KeyCode.DownArrow))
				{
					degrees += (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, rotSpeed * Time.deltaTime);
				}
				else
				{
					degrees -= (rotSpeed * Time.deltaTime);
					t.Rotate(0, 0, -rotSpeed * Time.deltaTime);
				}
			}
		}
		if (rb.position.y < 7.5f)
		{
			die();
		}

		if (rb.position.y< -1f)
		{
			GameObject.FindObjectOfType<GameManager>().EndGame();
		}
	}

    public void TakeDmg(int  dmgTaken)
    {
        hpLeft -= dmgTaken;
        if (hpLeft < 0)
        {
            hpLeft = 0;
        }
		dynaFric -= 0.2f;
        c.material.dynamicFriction = dynaFric;
		Debug.Log(dynaFric);
        rotSpeed -= (10 * dmgTaken);
        force -= 4;
    }
    public void die()
    {
        living = false;
		gm.Respawn();

	}
}
