using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    void Start()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            gameManager.SpawnBall();
        }
    }
}
