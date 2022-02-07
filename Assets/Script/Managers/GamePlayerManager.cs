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
        MakeDefualtDice();
    }

    //처음 만들어지는 다이스.
    public void MakeDefualtDice()
    {
        PlayerList[1000].AddDice(1);
        PlayerList[1000].AddDice(2);
        PlayerList[1000].AddDice(3);
        PlayerList[1000].AddDice(4);
        PlayerList[1000].AddDice(5);

        PlayerList[1001].AddDice(1);
        PlayerList[1001].AddDice(2);
        PlayerList[1001].AddDice(3);
        PlayerList[1001].AddDice(4);
        PlayerList[1001].AddDice(5);
    }
}
