using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ResourceHolder : MonoBehaviour
{
    public int Stones = 0;
    public int Woods = 0;
    public int Crystals = 0;
    public int RawFoods = 0;
    public int CookedFoods = 0;
    [SerializeField] Text ResourcesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI()
    {
        ResourcesText.text = 
            "Stone: " + Stones + 
            "\nWood: " + Woods + 
            "\nCrystal: " + Crystals + 
            "\nRaw Food: " + RawFoods +
            "\nCooked Food: " + CookedFoods;
    }
}
