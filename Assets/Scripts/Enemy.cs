using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
   // public Transform[] WayPoints;
    public Transform[] SpawnPoint;
    public int Maxbot;
    public GameObject bot;
    // Start is called before the first frame update
    void Start()
    {
        Maxbot = 0;
     
    }
    GameObject Create(GameObject Prefab)
    {
        Vector3 pos = SpawnPoint[Random.Range(0, SpawnPoint.Length - 1)].position;
        return Instantiate(bot, pos, Quaternion.identity);
    }
    void Test()
    {
        Create(bot);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Maxbot <= 3)
        {
            Test();
            Maxbot++;
        }
       
    }
}
