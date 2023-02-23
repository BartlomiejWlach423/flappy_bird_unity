using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject EndGameUI;
    public TextMeshProUGUI pointsUI;
    public float points;
    Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        Time.timeScale = 1f;

        pointsUI.text = points.ToString();
    }
    private void Update()
    {
        if(player.IsHit == true)
        {
            EndGameUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void AddPoints()
    {
        points++;
        pointsUI.text = points.ToString();
    }
}
