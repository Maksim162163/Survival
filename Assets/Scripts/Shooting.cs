using UnityEngine;

[RequireComponent(typeof(MouseInput))]
public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private AudioClip _shoot;
    [SerializeField] private RotateArm _rotateArm;

    private AudioSource _sound;
    [SerializeField] private float _bulletForce = 10f;
    [SerializeField] private float _rateFire = 0.5f;
    [SerializeField] private float _lifeTime = 1.5f;
    private float _intervalFire;

    private void Start()
    {
        _intervalFire = _rateFire;
        _sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (_intervalFire >= _rateFire)
            {
                Shoot();
                _intervalFire = 0;
            }
        }

        _intervalFire += Time.deltaTime;
    }

    private void Shoot()
    {
        _sound.PlayOneShot(_shoot);
        GameObject bullet = Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        transform.rotation = Quaternion.Euler(0, 0, _rotateArm.angleRotationZ);

        if (_rotateArm.angleRotationZ > 90 || _rotateArm.angleRotationZ < -90)
            rb.AddForce(_firePoint.up * _bulletForce, ForceMode2D.Impulse);
        else
            rb.AddForce(-_firePoint.up * _bulletForce, ForceMode2D.Impulse);

        Destroy(bullet, _lifeTime);
    }
}
