using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Tilemap))]
public class DungeonGenerator : MonoBehaviour
{
    private Tilemap _tilemap;
    public Dungeon _dungeon;

    public Tile[] tiles;

    public string dungeonShapes = "room-types";

    void Awake()
    {
        _tilemap = GetComponent<Tilemap>();
        _dungeon = new Dungeon(dungeonShapes);
    }

    private void Start()
    {
        var blocks = _dungeon.Generate();
        foreach (var block in blocks)
        {
            _tilemap.SetTile(block.Position, tiles[block.Id]);
        }

        // AT THE VERY END, YOU MUST ADD COLLIDER!
        gameObject.AddComponent<TilemapCollider2D>();
    }


}
