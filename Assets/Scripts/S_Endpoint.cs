using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Endpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(endGame());
    }

    IEnumerator endGame()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Map_End");
    }
}
