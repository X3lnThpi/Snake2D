using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameHandler Working");

        GameObject snakeheadGameObject = new GameObject();
       SpriteRenderer snakeSpriteRenderer = snakeheadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.instance.snakeHeadSprite;  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}