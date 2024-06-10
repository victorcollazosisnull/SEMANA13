using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float horizontal;
    public float speed;
    private Rigidbody2D _rigidbody2D;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public AudioSource _audioSource;
    // Start is called before the first frame update
    void Awake ()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(speed * horizontal, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.velocity = new Vector2(0, bulletSpeed);
            _audioSource.Play();
        }
    }           
}

