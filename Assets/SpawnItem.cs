using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] List<GameObject> item_prefebs = new List<GameObject>();
    [SerializeField] List<GameObject> mob_prefebs = new List<GameObject>();
    [SerializeField] GameObject End_Obj;

    private static SpawnItem _instance { get; set; } = null;
    public static SpawnItem Get2()
    {
        if (_instance == null)
            Debug.LogError($"{nameof(GameManager)}'s instance is null");

        return _instance;
    }
    private void Awake()
    {
        if (_instance == null)
            _instance = this;
    }
    private void Start()
    {
        StartCoroutine(spawn());

    }
    private void Update()
    {
  
    }
   public void End() 
    {
        StopAllCoroutines();
        Instantiate(End_Obj);
    }
    IEnumerator spawn()
    {
        yield return new WaitForSecondsRealtime(2);
        int rand = Random.Range(0, 10);
        switch (rand)
        {
            case 0:
                Instantiate(item_prefebs[0]);
                break;
            case 1:
                Instantiate(item_prefebs[1]);
                break;
            case 2:
                Instantiate(mob_prefebs[0]);
                break;
            case 3:
                Instantiate(mob_prefebs[1]);
                break;
            case 4:
                Instantiate(mob_prefebs[0]);
                break;
            case 5:
                Instantiate(mob_prefebs[1]);
                break;
            case 6:
                Instantiate(mob_prefebs[0]);
                break;
            case 7:
                Instantiate(mob_prefebs[1]);
                break;
            case 8:
                Instantiate(mob_prefebs[0]);
                break;
            case 9:
                Instantiate(mob_prefebs[1]);
                break;
            case 10:
                Instantiate(mob_prefebs[0]);
                break;

        }
        StartCoroutine(spawn());
    }
}