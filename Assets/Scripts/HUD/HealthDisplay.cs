using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject heart6;
    public GameObject heart7;
    public GameObject heart8;
    public GameObject heart9;
    public GameObject heart10;

    public Sprite healthFull;
    public Sprite healthEmpty;

    private Image[] _hearts;
    private PlayerController playerController;

    void Start()
    {
        _hearts = new Image[10];

        _hearts[0] = heart1.GetComponent<Image>();
        _hearts[1] = heart2.GetComponent<Image>();
        _hearts[2] = heart3.GetComponent<Image>();
        _hearts[3] = heart4.GetComponent<Image>();
        _hearts[4] = heart5.GetComponent<Image>();
        _hearts[5] = heart6.GetComponent<Image>();
        _hearts[6] = heart7.GetComponent<Image>();
        _hearts[7] = heart8.GetComponent<Image>();
        _hearts[8] = heart9.GetComponent<Image>();
        _hearts[9] = heart10.GetComponent<Image>();

        playerController = GlobalController.Instance.player.GetComponent<PlayerController>();
    }

    void Update()
    {
        int healthRemain = playerController.health;
        for (int i = 0; i < healthRemain; ++i)
        {
            _hearts[i].sprite = healthFull;
        }

        for (int i = healthRemain; i < 10; ++i)
        {
            _hearts[i].sprite = healthEmpty;
        }
    }
}
