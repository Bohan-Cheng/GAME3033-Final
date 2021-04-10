using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Map_Menu");
    }

    public void GotoGame()
    {
        SceneManager.LoadScene("Map_Game");
    }

    public void GotoCredit()
    {
        SceneManager.LoadScene("Map_Credit");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
