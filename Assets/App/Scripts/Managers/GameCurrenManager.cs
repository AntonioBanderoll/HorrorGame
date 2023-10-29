using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCurrenManager : MonoBehaviour
{
    public int coinValue;
    
    
    public static GameCurrenManager Instance => _instance;
    private static GameCurrenManager _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        UpdateInfo();
    }

    // Update is called once per frame
    void UpdateInfo()
    {
        coinValue = PlayerPrefs.GetInt("CoinsValue", 0);
    }

    public void AddCois(int count)
    {
        PlayerPrefs.SetInt("CoinsValue",PlayerPrefs.GetInt("CoinsValue", 0)+count);
        UpdateInfo();
    }

    public void AddCrystals(int count)
    {
        PlayerPrefs.SetInt("CrystalsValue",PlayerPrefs.GetInt("CrystalsValue", 0)+count);
        UpdateInfo();
    }

    public void AddKeys(int count)
    {
        PlayerPrefs.SetInt("KeysValue",PlayerPrefs.GetInt("KeysValue", 0)+count);
        UpdateInfo();
    }
}
