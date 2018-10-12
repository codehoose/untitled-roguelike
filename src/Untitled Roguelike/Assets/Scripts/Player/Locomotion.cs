using UnityEngine;

public class Locomotion : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
            MessageQueue.Instance.Post(new MovePlayer(Vector2.right));
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            MessageQueue.Instance.Post(new MovePlayer(Vector2.left));
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            MessageQueue.Instance.Post(new MovePlayer(Vector2.up));
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            MessageQueue.Instance.Post(new MovePlayer(Vector2.down));
    }
}
