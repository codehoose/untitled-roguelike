using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestManager : ReceiverMonoBehaviour<OpenChest>
{
    private List<TreasureChest> _opened = new List<TreasureChest>();

    public override void Handle(OpenChest message)
    {
        if (_opened.Contains(message.TreasureChest))
            return;

        // TODO: Handle treasure drop
        message.TreasureChest.Open();
        _opened.Add(message.TreasureChest);
    }

    protected override void OnAwake()
    {
        
    }
}
