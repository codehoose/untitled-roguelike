using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public bool Opened { get; private set; }

    public Sprite openSprite;   
    
    public void Open()
    {
        Opened = true;
        GetComponent<SpriteRenderer>().sprite = openSprite;
    }
}
