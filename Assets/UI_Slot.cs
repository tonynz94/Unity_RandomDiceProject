using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Slot : MonoBehaviour
{
    public bool _isFull;
    public int _diceTemplateID;
    public Texture _diceTexture;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AddDiceInThisSlot(int diceNum)
    {
        if (_isFull)
            return false;

        _isFull = true;
        _diceTemplateID = diceNum;
        //_diceTexture = ManagerContainer.Data.diceDict[diceNum].diceTexture;

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
