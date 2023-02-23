using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    Generator generator;
    UI pointsUI;
    private void Start()
    {
        generator = FindObjectOfType<Generator>();
        pointsUI = FindObjectOfType<UI>();
    }
    private void OnTriggerEnter(Collider other)
    {
        generator.CreateObstacle();
        pointsUI.AddPoints();
    }
}
