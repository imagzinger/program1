using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    MainMenu mm;
    // Start is called before the first frame update
    void onClick()
    {
        if (this.tag == "speed")
        {
            mm.PlayRaceTrack();
        }
        else if (this.tag == "cliff")
        {
            mm.PlayCliffTrack(); 
        }
    }
}
