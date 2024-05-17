using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject readyButton;
    public GameObject shootButtons;
    public GameObject ball;
    public GameObject ballSpawn;
    public ParticleSystem leftparticle;
    public ParticleSystem rightparticle;
    // Start is called before the first frame update
    void Start()
    {
        leftparticle.Stop();
        rightparticle.Stop();
        shootButtons.SetActive(false);
    }
    public void playLeft()
    {
        leftparticle.Play();
    }
    public void playRight()
    {
        rightparticle.Play();
    }
    public void SpawnBall()
    {
        Instantiate(ball, ballSpawn.transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
