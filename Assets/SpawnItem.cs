using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] List<GameObject> item_prefebs = new List<GameObject>();
    [SerializeField] List<GameObject> mob_prefebs = new List<GameObject>();
    IEnumerator spawn()
    {
        yield return new WaitForSecondsRealtime(1);
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                Instantiate(item_prefebs[0],)
                break;
        }
    }
}