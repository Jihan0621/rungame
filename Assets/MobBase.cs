using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBase : MonoBehaviour
{
    // Start is called before the first frame update
    float mobSpeed = 4;
    Vector2 StartPosition = new Vector2(11, -3.5f);
    public bool isItem = false;
    public bool islog = false;
    public bool isvine = false;

    public void Start()
    {
        if (isItem)
        {
            StartPosition = new Vector2(11, Random.Range(-3.5f, 3.5f));
            //이재원 왔다감 ^^
        }
        else
        {
            StartPosition = new Vector2(11, -3.5f);
        }
    }
    private void OnEnable()
    {
        transform.position = StartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * mobSpeed);

        if (transform.position.x < -10)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.Get().Hpdown();
            if (isvine)
            {
                GameManager.Get().vineCount++;
            }
            else if (islog)
            {
                GameManager.Get().logCount++;
            }
            gameObject.SetActive(false);
        }
    }
}
