using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _target;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _spreadX;
    [SerializeField] private float _spreadY;

    private float _spawnInterval;
    private Vector2 _spawnPosition;
    private Vector3 _spawnerPosition;

    private void Start()
    {
        _spawnInterval = _spawnDelay;
    }

    private void Update()
    {
        _spawnerPosition = _target.position + _offset;

        if (_spawnInterval <= 0)
        {
            _spawnInterval = _spawnDelay;

            float positionX = Random.Range(_spawnerPosition.x - _spreadX, _spawnerPosition.x + _spreadX);
            float positionY = Random.Range(_spawnerPosition.y - _spreadY, _spawnerPosition.y + _spreadY);

            _spawnPosition = new Vector2(positionX, positionY);

            Instantiate(_enemy, _spawnPosition, Quaternion.identity);
        }
        else
            _spawnInterval -= Time.deltaTime;
    }
}
