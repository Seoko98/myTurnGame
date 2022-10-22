using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneControl : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerHP;
    public GameObject player;
    public GameObject playerHPBar;

    // ActionUI
    public Image actionBar;
    public Image player1Action;
    public Image enemy1Action;
    public TextMeshProUGUI player1ActionText;

    // Start is called before the first frame update
    void Start()
    { 
        playerName.text = player.GetComponent<PlayerInfo>().hero.getName();
        playerName.transform.position.Set(-400f, -200f, 0f);
        playerName.color = Color.black;
        
        playerHP.transform.position.Set(-400.0f, -230.0f, 0.0f);

        player1ActionText.text = player.GetComponent<PlayerInfo>().hero.getName();

        Color playerColor = player.GetComponent<Material>().color;
        playerColor.a = 0.5f;
        player1Action.color = playerColor;
    }

    // Update is called once per frame
    void Update()
    {
        playerHPBar.transform.position = Camera.main.WorldToScreenPoint(
            player.transform.position + new Vector3(0.0f, 0.8f, 0.0f));

        playerHP.text = player.GetComponent<PlayerInfo>().hero.getHP().ToString()
            + " / " + player.GetComponent<PlayerInfo>().hero.getHP().ToString();

        player1ActionText.transform.position = player1Action.transform.position +
            new Vector3(125.0f, -17.5f, 0.0f);

        if (!isAction(player1Action.rectTransform.position.y))
        {
            player1Action.transform.Translate(Vector3.down * Time.deltaTime
               * player.GetComponent<PlayerInfo>().hero.getSpeed());
        }
        else
        {
            player1Action.transform.Translate(Vector3.zero);
        }
    }

    // 액션 바의 행동 게이지가 바닥에 닿으면 턴
    public bool isAction(float PosY)
    {
        if (PosY <= 182.0f)
            return true;

        return false;
    }
}
