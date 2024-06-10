using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionPrefab;
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigos")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            _animator.SetTrigger("explosion");
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
    }
}
