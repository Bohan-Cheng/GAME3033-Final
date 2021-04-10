using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_ResourceHolder : MonoBehaviour
{
    public int Stones = 0;
    public int Woods = 0;
    public int Crystals = 0;
    public float Health = 100;
    [SerializeField] Text ResourcesText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            if(Vector3.Distance(g.transform.position, transform.position) <= 3.0f)
            {
                Health -= 0.01f;
                if (Health <= 0)
                {
                    Health = 0;
                    Death();
                }
                UpdateUI();
            }
        }
    }

    void Death()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Map_End");
    }

    public void UpdateUI()
    {
        ResourcesText.text =
            "Stone: " + Stones +
            "\nWood: " + Woods +
            "\nCrystal: " + Crystals +
            "\nHealth: " + (int)Health + " / 100";
    }
}
