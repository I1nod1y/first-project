using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Публичная переменная для префаба пули
    public Transform bulletSpawnPoint; // Публичная переменная для точки появления пули
    public float bulletSpeed = 10f; // Скорость пули

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bulletRigidbody.AddForce(bullet.transform.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}