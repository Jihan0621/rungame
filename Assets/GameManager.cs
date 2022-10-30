using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text green_text;
    [SerializeField] Text brown_text;
    public int logCount;
    public int vineCount;
    public int green = 0;
    public int brown = 0;
    
    int Hp = 3;
    [SerializeField] List<GameObject> Hp_img = new List<GameObject>();
    private void Update()
    {
        Hpset();
        set_text();
    }

    private static GameManager _instance { get; set; } = null;
    public static GameManager Get()
    {
        if (_instance == null)
            Debug.LogError($"{nameof(GameManager)}'s instance is null");

        return _instance;
    }
    private void Awake()
    {
        if (_instance == null)
            _instance = this;
    }
    void Hpset()
    {
        switch (Hp)
        {
            case 0:
                if (Hp < 0)
                    Hp = 0;
                Hp_img[0].SetActive(false);
                Hp_img[1].SetActive(false);
                Hp_img[2].SetActive(false);
                break;
            case 1:
                Hp_img[1].SetActive(false);
                Hp_img[2].SetActive(false);
                break;
            case 2:
                Hp_img[2].SetActive(false);
                break;
            case 3:
                Hp_img[0].SetActive(true);
                Hp_img[1].SetActive(true);
                Hp_img[2].SetActive(true);

                break;
        }

    }
    public void Hpdown() { Hp--; }

    public void greenup() { green++; }
    public void brownup() { brown++; }
    
    public void set_text()
    {
        green_text.text = green + "°³";
        brown_text.text = brown + "°³";
    }
}
