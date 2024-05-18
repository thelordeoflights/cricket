using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public void Skip()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
