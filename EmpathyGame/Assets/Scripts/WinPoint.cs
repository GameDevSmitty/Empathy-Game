using UnityEngine;
using System.Collections;

public class WinPoint : MonoBehaviour
{
    public bool hasPlayerWon = false;

    void onTriggerEnter(Collider other)
    {
            hasPlayerWon = true;
    }

}
