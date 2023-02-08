using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Playbutton assigned to move to next level
    public GameObject playButton;
    //On click PlayButton Load Next Scene Which is game
    public void moveToGameScene()
    {
        SceneManager.LoadScene(1);
    }
    
}
