using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public GameObject tailPrefab;
    Vector2 dir = Vector2.right;
    //Keep track of Tails
    List<Transform> tail = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;    // '-up' means 'down'
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right; // '-right' means 'left'
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
    }

    void Move()
    {
        Vector2 v = transform.position;
        transform.Translate(dir);
       // GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
        //tail.Insert(0, g.transform);
    }
}
