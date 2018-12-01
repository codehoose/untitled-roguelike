using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Tilemap))]
public class DungeonGenerator : MonoBehaviour
{
    private Tilemap _tilemap;
    private TilemapModel _tilemapModel;

    public Tile[] tiles;

    public string dungeonShapes = "room-types";

    void Awake()
    {
        _tilemap = GetComponent<Tilemap>();

        // TODO: PUT IN ANOTHER CLASS!!
        var dungeonJson = Resources.Load<TextAsset>(dungeonShapes).text;
        _tilemapModel = JsonUtility.FromJson<TilemapModel>(dungeonJson);



    }

    private void Start()
    {
        var blocks = _tilemapModel.layers[0].data;

        for (int y = 0; y < 12; y++)
        {
            for (int x = 0; x < 16; x++)
            {
                var blockId = blocks[y * 16 + x] - 1;
                if (blockId < 0)
                    continue;

                var actualY = 6 - y;
                var actualX = -8 + x;

                _tilemap.SetTile(new Vector3Int(actualX, actualY, 0), tiles[blockId]);
            }
        }

        // AT THE VERY END, YOU MUST ADD COLLIDER!
        gameObject.AddComponent<TilemapCollider2D>();
    }


}
