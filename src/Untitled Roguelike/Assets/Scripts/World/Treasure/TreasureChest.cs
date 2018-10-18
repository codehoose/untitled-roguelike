using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    private bool _closed = true;

    public Sprite openSprite;   
    
    public void Open()
    {
        GetComponent<SpriteRenderer>().sprite = openSprite;
    }
}
