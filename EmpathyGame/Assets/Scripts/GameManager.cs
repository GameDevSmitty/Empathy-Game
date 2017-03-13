using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    UnderwaterController playerUnderwater;
    [SerializeField]
    GameObject player;

    [SerializeField]
    WinPoint winZone;

    [SerializeField]
    Text centerText;

    int sceneToStart = 0;


    void Start ()
    {
        centerText.text = "Hurry the water is rising!!";
    }
	
	void Update ()
    {
        if (winZone.hasPlayerWon)
        {
            centerText.text = "You've been saved, Congratulations!";
            StartCoroutine(WaitAfterDeath());
            Application.Quit();
        }

        if (playerUnderwater.isDead)
        {
            centerText.text = "Oh no, you died.  Try Again!";
            player.SetActive(false);
            StartCoroutine(WaitAfterDeath());
            
        }
        if (playerUnderwater.breathTimer >= 45f)
        {
            centerText.text = "Oh no, you died.  Try Again!";
            player.SetActive(false);
            StartCoroutine(WaitAfterDeath());
        }
    }

    IEnumerator WaitAfterDeath()
    {
        yield return new WaitForSeconds(3);
        if (playerUnderwater.isDead)
            SceneManager.LoadScene(sceneToStart);
    }
}
