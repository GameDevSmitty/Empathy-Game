using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnderwaterController : MonoBehaviour
{

    [SerializeField]
    Transform water;

    [SerializeField]
    Transform player;

    [SerializeField]
    Image underWaterColor;

    [SerializeField]
    Color defaultWaterColor;

    [SerializeField]
    Slider breathSlider;

    public float breathTimer = 0f;
    public bool isDead = false;

	void Start ()
    {
	
	}
	

	void Update ()
    {
	    if (water.position.y - player.position.y >= .9f)
        {
            defaultWaterColor.a = .5f;
            underWaterColor.color = defaultWaterColor;

            breathTimer += Time.deltaTime;
            breathSlider.value -= Time.deltaTime;
        }
        else
        {
            defaultWaterColor.a = 0;
            underWaterColor.color = defaultWaterColor;

            breathTimer = 0f;
            breathSlider.value = 45f;
        }
	}

    public void PlayerHitByEnemy()
    {
        isDead = true;
    }
}
