using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    [Header("Views")] 
    [SerializeField] private GameObject shop;
    [SerializeField] private GameObject settings;
   // [SerializeField] private GameObject levels;

    [Space] [Header("Buttons")]
    [SerializeField] private Button[] homeButtons;
    [SerializeField] private Button shopButton;
    [SerializeField] private Button settingsButton;
   // [SerializeField] private Button levelsButton;
    
    
    [Space] [Header("TxtInfo")]
    [SerializeField] private TextMeshProUGUI menuCoin;
    [SerializeField] private TextMeshProUGUI shopCoin;
    
    
    void Start()
    {
        ButtonsClick();   
        UpdateTextInfo();
    }

    void ButtonsClick()
    {
        for (int i = 0; i < homeButtons.Length; i++)
        {
            homeButtons[i].onClick.AddListener(() => Home());
        }
        
        shopButton.onClick.AddListener((() => OpenView(shop)));
        settingsButton.onClick.AddListener((() => OpenView(settings)));
        //levelsButton.onClick.AddListener((() => OpenView(levels)));
    }
    
    void Home()
    {
        shop.SetActive(false);
        settings.SetActive(false);
       // levels.SetActive(false);
    }

    void OpenView(GameObject view)
    {
        view.SetActive(true); 
    }

    void UpdateTextInfo()
    {
        menuCoin.text = GameCurrenManager.Instance.coinValue.ToString();
        shopCoin.text = GameCurrenManager.Instance.coinValue.ToString();
    }
}
