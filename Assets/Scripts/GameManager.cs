using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject readyButton;
    public GameObject shootButtons;
    // Start is called before the first frame update
    void Start()
    {
        shootButtons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
