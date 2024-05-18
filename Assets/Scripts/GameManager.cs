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
    public GameObject currentBall;
    public ParticleSystem leftparticle;
    public ParticleSystem rightparticle;
    public ParticleSystem frontparticle;

    float swingDirection = 0;
    // Start is called before the first frame update
    void Start()
    {
        leftparticle.Stop();
        rightparticle.Stop();
        frontparticle.Stop();
        shootButtons.SetActive(false);
    }
    void SetBallDirection()
    {
        if (currentBall != null)
        {
            currentBall.GetComponent<BallThrow>().setDirection(swingDirection);
        }
    }
    public void noSwing()
    {
        frontparticle.Play();
        swingDirection = 0;
        SetBallDirection();
    }
    public void playLeft()
    {
        leftparticle.Play();
        swingDirection = -1;
        SetBallDirection();

    }
    public void playRight()
    {
        rightparticle.Play();
        swingDirection = 1;
        SetBallDirection();

    }
    public void SpawnBall()
    {
        currentBall = Instantiate(ball, ballSpawn.transform.position, Quaternion.identity);
        SetBallDirection();
    }

}
