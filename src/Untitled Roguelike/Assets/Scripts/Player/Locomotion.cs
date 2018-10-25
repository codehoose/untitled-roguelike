using UnityEngine;

public class Locomotion : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
            MovePlayer(Vector2.right);
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
            MovePlayer(Vector2.left);
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            MovePlayer(Vector2.up);
        else if (Input.GetKeyUp(KeyCode.DownArrow))
            MovePlayer(Vector2.down);
    }

    private void MovePlayer(Vector2 direction)
    {
        var canMovePlayer = TraversalManager.Instance.CanMovePlayer(transform.position, direction);

        if (canMovePlayer)
            MessageQueue.Instance.Post(new MovePlayer(direction));        
    }
}
