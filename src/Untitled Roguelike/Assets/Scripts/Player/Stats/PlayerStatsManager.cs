using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    // In the meantime, let's just have fields.
    public int _steps;
    public int _chests;

    void Start()
    {
        MessageQueue.Instance.Register<MovePlayer>(PlayerMoved);
        MessageQueue.Instance.Register<OpenChest>(ChestOpened);
    }

    private void PlayerMoved(MovePlayer movement)
    {
        _steps++;
    }

    private void ChestOpened(OpenChest chest)
    {
        _chests++;
    }
}
