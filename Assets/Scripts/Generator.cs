using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject obstacle;
    public float distance = 30;
    private void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            CreateObstacle();
        }
    }
    public void CreateObstacle()
    {
        Instantiate(obstacle, new Vector3(distance, Random.Range(1.4f,7.2f), 0), Quaternion.Euler(90, 0, 0));
        distance += 15;
    }
}
