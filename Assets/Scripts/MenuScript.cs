using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MenuScript : MonoBehaviour
{
    public void Level1()
    {
        Level.level = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void Level2()
    {
        Level.level = 2;
        SceneManager.LoadScene("SampleScene");
    }
    public void Level3()
    {
        Level.level = 3;
        SceneManager.LoadScene("SampleScene");
    }
}
