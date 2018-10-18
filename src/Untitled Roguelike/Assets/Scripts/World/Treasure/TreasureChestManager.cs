using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestManager : ReceiverMonoBehaviour<OpenChest>
{
    public override void Handle(OpenChest message)
    {
        // TODO: Handle treasure drop
        message.TreasureChest.Open();
    }

    protected override void OnAwake()
    {
        
    }
}
