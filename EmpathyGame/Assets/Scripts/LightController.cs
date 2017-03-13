using UnityEngine;
using System.Collections;
using System;

public class LightController : MonoBehaviour
{

    [SerializeField]
    Light[] spotlights;

    [SerializeField]
    Light finishLight;

    float clock = 0f;
    int clockMod10;
    Color white = Color.white;
    Color red = Color.red;

    void Start ()
    {
	
	}
	
	void Update ()
    {
        clock += Time.deltaTime;
        clockMod10 = Convert.ToInt32(clock % 10);
        Debug.Log(clockMod10);
        switch (clockMod10)
        {
            case 0:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = false;
                }
                finishLight.color = white;
                break;
            case 1:
                foreach (Light sl in spotlights)
                {
                    if (sl.enabled)
                        sl.enabled = false;
                    else
                        sl.enabled = true;
                }
                finishLight.color = red;
                break;
            case 2:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = true;
                }
                finishLight.color = white;
                break;
            case 3:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = true;
                }
                finishLight.color = red;
                break;
            case 4:
                foreach (Light sl in spotlights)
                {
                    if (sl.enabled)
                        sl.enabled = false;
                    else
                        sl.enabled = true;
                }
                finishLight.color = white;
                break;
            case 5:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = false;
                }
                finishLight.color = red;
                break;
            case 6:
                foreach (Light sl in spotlights)
                {
                    if (sl.enabled)
                        sl.enabled = false;
                    else
                        sl.enabled = true;
                }
                finishLight.color = white;
                break;
            case 7:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = false;
                }
                finishLight.color = red;
                break;
            case 8:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = false;
                }
                finishLight.color = white;
                break;
            case 9:
                foreach (Light sl in spotlights)
                {
                    if (sl.enabled)
                        sl.enabled = false;
                    else
                        sl.enabled = true;
                }
                finishLight.color = red;
                break;
            case 10:
                foreach (Light sl in spotlights)
                {
                    sl.enabled = true;
                }
                finishLight.color = white;
                break;
            default:
                break;
        }
	}
}
