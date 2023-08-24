using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int player;
    private int AI;
    public TextMeshProUGUI scoreTextPlayer;
    public TextMeshProUGUI scoreTextComputer;

    void Start()
    {
        player = 0;
        scoreTextPlayer.SetText(player.ToString());

        AI = 0;
        scoreTextComputer.SetText(AI.ToString());
    }
    public void PlayerScore()
    {
        player++;
        scoreTextPlayer.SetText(player.ToString());
    }
    public void AIScore()
    {
        AI++;
        scoreTextComputer.SetText(AI.ToString());
    }

}
