using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Collider _collider;
    public GameObject _health;
    public PlayerController _player;
    int Lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
     if(_collider.tag == "player")
        {
            _player = GetComponent<PlayerController>();
            Lives++;
            Destroy(_health);
        }
    }
}
