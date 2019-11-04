using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerScript : MonoBehaviour
{
    [SerializeField] public Animator _animator;
    public float moveSpeed = 10f;
    public GameObject crawler = new GameObject("crawler");
    private bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            crawler.transform.Translate(-Time.deltaTime * moveSpeed, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        _animator.SetBool("crawl", true);
        activated = true;
    }
    

}
