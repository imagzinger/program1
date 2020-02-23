using UnityEngine;
using System;

public class followplayer : MonoBehaviour
{
	public Transform Player;
    //public Transform Player2;
	public Vector3 offset;
    public float distBtwn;

    public float xRot;
    public float yRot;
    public float zRot;
    public float z;
    public float x;
    public float y;
    // Update is called once per frame
    void Update()
    {
        float p1z = Player.position.z;
        //float p2z = Player2.position.z;
        
        // = Player.position.z;
   //     if (Math.Abs(p2z - p1z) > distBtwn) 
   //     {
			//if (p2z > p1z)
   //             z = p1z;
   //         else if(p1z > p2z) 
   //             z = p2z;
   //     }
        //z = (p1z + p2z) / 2.0f;
        z = p1z;
        x = Player.position.x;
        y = Player.position.y;
        transform.position = new Vector3( /*(Player2.position.x + Player.position.x)/2*/x+offset.x, y+offset.y, (z + offset.z));
        //transform.Rotate(0, 0, 90);
       // transform.localEulerAngles = new Vector3(xRot, yRot, zRot);
    }
}
