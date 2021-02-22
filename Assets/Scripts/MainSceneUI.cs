using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneUI : MonoBehaviour
{
    public InputField playerHandle;
    public InputField playerAge;
    public string playerName;
    public int myAge;

    public void PlayerHandleUpdate()
    {
        playerName = playerHandle.text;
    }

    public void PlayerAgeUpdate()
    {
        myAge = int.Parse(playerAge.text);
    }

    public void Play()
    {
        Debug.Log("name and age of player is " + playerName + myAge); //<--Putting this here because can't see debug messages on the webGL build

        PlayerPrefs.SetString("ThisPlayer", playerName);
        PlayerPrefs.SetInt("ThisAge", myAge);
        SceneManager.LoadScene("Game");
    }
}
