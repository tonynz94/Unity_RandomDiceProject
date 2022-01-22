using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_BattleGroundBG : MonoBehaviour
{

    UI_Slot[] slots;
    const int MAX_DICE = 15;
    int current_dice;

    // Start is called before the first frame update
    void Start()
    {
        current_dice = 0;
        slots = transform.GetComponentsInChildren<UI_Slot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Player1MakeDice()
    {
        int dice, x, y;
        do
        {
            if (current_dice < MAX_DICE)
                return;
            dice = Random.Range(0, 4);
            x = Random.Range(0, 4);
            y = Random.Range(0, 2);
        } while (!slots[x + y].SetDiceInThisSlot(dice));
    }

    public void Player2MakeDice()
    {
        int dice, x, y;
        do
        {
            if (current_dice < MAX_DICE)
                return;
            dice = Random.Range(0, 4);
            x = Random.Range(0, 4);
            y = Random.Range(0, 2);
        } while (!slots[x + y].SetDiceInThisSlot(dice));
    }
}
