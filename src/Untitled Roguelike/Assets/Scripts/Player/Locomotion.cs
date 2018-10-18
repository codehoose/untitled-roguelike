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
        var hit = Physics2D.Raycast(transform.position, direction, 1f);
        if (hit && hit.collider.tag == WorldObjectTag.Impassable)
            return;

        if (hit && hit.collider.tag == WorldObjectTag.TreasureChest)
        {
            var openChest = new OpenChest(hit.collider.GetComponent<TreasureChest>());
            MessageQueue.Instance.Post(openChest);
            return;
        }

        MessageQueue.Instance.Post(new MovePlayer(direction));        
    }
}
