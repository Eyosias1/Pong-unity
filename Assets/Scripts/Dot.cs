using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dot : MonoBehaviour
{
    public string nextLevel;
    public static int i;
    public int DotNumber = 0;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Crate")
        {
            i +=1;
        } 
        if (collision.gameObject.name == "Crate2")
        {
            i +=1;
        }
        if (collision.gameObject.name == "Crate3")
        {
            i += 1;
        }
        if (collision.gameObject.name == "Crate4")
        {
            i += 1;
        }
    }

    IEnumerator MyCoroutine() 
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextLevel);
    }

    // Start is called before the first frame update
    public void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (i == DotNumber)
        {
            i = 0;
            Player.GetComponent<Player>().isAbleToMove = false;
            StartCoroutine(MyCoroutine());
        }
    }
}