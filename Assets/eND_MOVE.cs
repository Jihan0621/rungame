using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eND_MOVE : MonoBehaviour
{
    float itemSpeed = 4;
    private Vector2 startposition = new Vector2(11, -3.5f);
    private void Start()
    {
        startposition = new Vector2(11, Random.Range(-3.5f, 3.5f));
    }
    private void OnEnable()
    {
        transform.position = startposition;
    }
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * itemSpeed);

        if (transform.position.x < -10)
        {
            gameObject.SetActive(false);
        }
    }
}
