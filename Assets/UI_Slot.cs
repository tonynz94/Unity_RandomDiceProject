using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Slot : UI_Base
{
    public bool _isFull;
    public int _diceTemplateID;
    public Image _diceTexture;

    public override void Init()
    {
        _diceTexture = GetComponent<Image>();
    }

    public bool AddDiceInThisSlot(int diceIndex, int playerNumber)
    {
        if (_isFull)
            return false;

        _isFull = true;
        _diceTemplateID = ManagerContainer.Players.PlayerList[playerNumber]._myAllDice[diceIndex];
        _diceTexture.sprite = ManagerContainer.Data.DiceStatDict[_diceTemplateID].diceImage;

        return true;
    }

    public bool RemoveDiceInThisSlot()
    {
        //비어있다면 false반환
        if (!_isFull)
            return false;

        _isFull = false;
        return true;    
    }
}
