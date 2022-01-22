using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerManager
{
    public int _playerCount = 0;

    Dictionary<int, GamePlayer> player_list = new Dictionary<int, GamePlayer>();

    public Dictionary<int, GamePlayer> PlayerList
    {
        get
        {
            return player_list;
        }
    }

    public void Init()
    {
        player_list.Add(1000 ,new GamePlayer(1000));  //Player1
        player_list.Add(1001 ,new GamePlayer(1001));  //Player2
    }

    //처음 만들어지는 다이스.
    public void MakeDefualtDice()
    {
        PlayerList[1000].AddDice(10000);
        PlayerList[1000].AddDice(11000);
        PlayerList[1000].AddDice(12000);
        PlayerList[1000].AddDice(13000);
        PlayerList[1000].AddDice(14000);

        PlayerList[1001].AddDice(10000);
        PlayerList[1001].AddDice(11000);
        PlayerList[1001].AddDice(12000);
        PlayerList[1001].AddDice(13000);
        PlayerList[1001].AddDice(14000);
    }
}
