using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define 
{

    public delegate void DiceEventProcDelegate(int param1);

    public delegate void DiceEventProcDelegateObj(object param1);


    public enum Scene
    {
        Unknown,
        MainLobby,
        BattleGame,
        Loading
    };

    public enum UIEvent
    {
        Click,
        ClickDown,
        Drag,
        DragBegin,
        DragEnd,
        MoushEnter,
        MoushExit,
    };


}
