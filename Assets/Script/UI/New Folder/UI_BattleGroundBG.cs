using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BattleGroundBG : MonoBehaviour
{

    UI_Slot[] Player1Slots;
    UI_Slot[] Player2Slots;
    const int MAX_DICE = 15;
    int current_dice;

    // Start is called before the first frame update
    void Start()
    {
        current_dice = 0;
        Player1Slots = transform.GetComponentsInChildren<UI_Slot>();
        Player2Slots = transform.GetComponentsInChildren<UI_Slot>();
    }

        // Update is called once per frame
    void Update()
    {

    }

    public void Player1MakeDice()
    {
        int diceIndex, x, y;
        do
        {
            if (current_dice >= MAX_DICE)
                return;
            diceIndex = Random.Range(0, ManagerContainer.Players.PlayerList[1000]._myAllDice.Count);
            x = Random.Range(0, 5); //0 1 2 3 4
            y = Random.Range(0, 3); //0 1 2
        } while (!Player1Slots[(y * 5) + x].AddDiceInThisSlot(diceIndex, 1000));
        current_dice++;

    }

    public void Player2MakeDice()
    {
        int diceIndex, x, y;
        do
        {
            if (current_dice >= MAX_DICE)
                return;
            diceIndex = Random.Range(0, 4);
            x = Random.Range(0, 5);
            y = Random.Range(0, 2);
        } while (!Player1Slots[(y * 5) + x].AddDiceInThisSlot(diceIndex, 1001)) ;
        current_dice++;
    }
}
