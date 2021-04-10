using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S_UnbuildObject : MonoBehaviour
{
    public int RStones = 0;
    public int RWoods = 0;
    public int RCrystals = 0;

    public int Stones = 0;
    public int Woods = 0;
    public int Crystals = 0;

    [SerializeField] TextMeshProUGUI ResourcesText;
    [SerializeField] GameObject buildObject;
    S_ResourceHolder rh;

    // Start is called before the first frame update
    void Start()
    {
        rh = FindObjectOfType<S_ResourceHolder>();
        UpdateUI();
    }

    void UpdateUI()
    {
        ResourcesText.text = "";
        if (RStones != 0) ResourcesText.text += "Stone: " + Stones + " / " + RStones + "\n";
        if (RWoods != 0) ResourcesText.text += "Wood: " + Woods + " / " + RWoods + "\n";
        if (RCrystals != 0) ResourcesText.text += "Crystal: " + Crystals + " / " + RCrystals + "\n";
    }

    void Build()
    {
        Instantiate(buildObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        int needStones = RStones - Stones;
        int needWoods = RWoods - Woods;
        int needCrystals = RCrystals - Crystals;

        if (RStones != 0)
        {
            if (rh.Stones <= needStones)
            {
                Stones += rh.Stones;
                rh.Stones = 0;
            }
            else
            {
                Stones += needStones;
                rh.Stones -= needStones;
            }

        }

        if (RWoods != 0)
        {
            if (rh.Woods <= needWoods)
            {
                Woods += rh.Woods;
                rh.Woods = 0;
            }
            else
            {
                Woods += needWoods;
                rh.Woods -= needWoods;
            }
        }

        if (RCrystals != 0)
        {
            if (rh.Crystals <= needCrystals)
            {
                Crystals += rh.Crystals;
                rh.Crystals = 0;
            }
            else
            {
                Crystals += needCrystals;
                rh.Crystals -= needCrystals;
            }
        }



        UpdateUI();
        rh.UpdateUI();

        if (Stones == RStones
            && Woods == RWoods
            && Crystals == RCrystals)
        {
            Build();
        }
    }
}
