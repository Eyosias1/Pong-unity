using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rigidBody2D;
    private float movementV;
    private float movementH;
    private Vector3 startPosition;
    public Collider2D collision;
    public bool isAbleToMove;
    public float moves1;
    public GameObject Moves;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Crate")
        {
            movementV = Input.GetAxis("Vertical");
            movementH = Input.GetAxis("Horizontal");
            rigidBody2D.velocity = Vector2.zero;

        }
        if (collision.gameObject.tag == "Mur")
        {
            GetComponent<AudioSource>().Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isAbleToMove = true;
    }

    // Update is called once per frame
    public void Update()
    {
        movementV = Input.GetAxis("Vertical");
        movementH = Input.GetAxis("Horizontal");
        rigidBody2D.velocity = new Vector2(movementH, movementV) * speed;
        moves1 += Time.deltaTime;
        Moves.GetComponent<TextMeshProUGUI>().text = moves1.ToString("0");
    }
}
