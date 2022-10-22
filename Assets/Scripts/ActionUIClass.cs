using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionUI
{
    private Image actionBar;
    private List<Image> playerActions = new List<Image>();
    private List<Image> enemyActions = new List<Image>();
    private List<TextMeshProUGUI> playerActionTexts = new List<TextMeshProUGUI>();
    private List<TextMeshProUGUI> enemyActionTexts = new List<TextMeshProUGUI>();
    private int playerCount = 1, enemyCount = 1;

    public ActionUI(int playerCount, int enemyCount)
    {
        this.playerCount = playerCount;
        this.enemyCount = enemyCount;
    }

    public void Initialize()
    {
        
    }
}