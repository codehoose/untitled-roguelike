﻿using System.Collections;
using UnityEngine;

public class AnimatedMovement : ReceiverMonoBehaviour<MovePlayer>
{
    private bool _moving = false;
    private float _duration = 0.1f;

    public override void Handle(MovePlayer message)
    {
        if (_moving)
            return;

        var start = transform.position;
        var end = new Vector3(message.Direction.x, message.Direction.y);
        end += start;
        _moving = true;

        StartCoroutine(MovePlayer(start, end));
    }

    protected override void OnAwake()
    {
        
    }

    private IEnumerator MovePlayer(Vector3 start, Vector3 end)
    {
        float t = 0;
        while (t < 1f)
        {
            transform.position = Vector3.Lerp(start, end, t);
            t += Time.deltaTime / _duration;
            yield return null;
        }

        transform.position = end;
        MessageQueue.Instance.Post(new MovePlayerEnd(start, end));
        _moving = false;
    }
}
