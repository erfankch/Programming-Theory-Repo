using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 15.0f;
    private float repeatWidth;
    private float wallBlockWidth;

    private Vector3 startPos;
    public GameObject wallBlock;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        wallBlockWidth = wallBlock.GetComponent<BoxCollider>().size.x;
        repeatWidth = wallBlockWidth * 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDownWall();
        repeatWall();
    }

    void MoveDownWall()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    void repeatWall()
    {
        if (transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
