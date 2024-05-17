using UnityEngine;
using UnityEngine.Playables;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] PlayableDirector playableDirector1;
    [SerializeField] PlayableDirector playableDirector2;
    [SerializeField] GameManager gameManager;

    public void onReadyButtonPressed()
    {
        gameManager.readyButton.SetActive(false);
        playableDirector1.Play();
        playableDirector1.stopped += OnTimeLineStart;
    }

    void OnTimeLineStart(PlayableDirector playableDirector)
    {
        gameManager.shootButtons.SetActive(true);
        gameManager.ball.SetActive(true);
        gameManager.SpawnBall();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
