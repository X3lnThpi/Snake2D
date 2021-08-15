using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    private LevelGrid levelGrid;
    [SerializeField] private Snake snake;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("GameHandler Working");
        levelGrid = new LevelGrid(20, 20);
        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
        GameObject snakeheadGameObject = new GameObject();
       SpriteRenderer snakeSpriteRenderer = snakeheadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.instance.snakeHeadSprite;  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
