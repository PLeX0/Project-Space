using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShoting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform weaponBarrel;

    
    public SpriteRenderer weapon;
    public Sprite weaponSpriteR;
    public Sprite weaponSpriteL;
    public Sprite weaponSprite;

    public PlayerStats playerStats;

    public float reloadTimer = 1f;
    public float reloading;

    private Vector2 lookDirection;
    private float lookAngle;

    void Start()
    {
        reloading = reloadTimer / playerStats.reloadSpeed;
    }

    void Update()
    {
        weapon.sprite = weaponSprite;
        bullet.SetActive(false);

        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, lookAngle);

        if(Input.GetMouseButton(0))
        {
            

            reloading -= Time.deltaTime;
            if(reloading<=0)
               FireBullet();                      
        }
        else if (!Input.GetMouseButton(0))
        {
            reloading -= Time.deltaTime;
        }

        if (lookAngle >= 90f && lookAngle <= 270f)
            weaponSprite = weaponSpriteL;
        if (lookAngle >= -90f && lookAngle <= 90f)
            weaponSprite = weaponSpriteR;
        else
            weaponSprite = weaponSpriteL;


        
    }
    
    private void FireBullet()
    {
        reloading = reloadTimer / playerStats.reloadSpeed;
        bullet.SetActive(true);
        GameObject firedBullet = Instantiate(bullet, weaponBarrel.position, weaponBarrel.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = weaponBarrel.right * 7f;
        Destroy(firedBullet, 5f);
    }



}
