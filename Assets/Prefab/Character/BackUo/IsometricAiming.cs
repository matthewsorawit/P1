using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BarthaSzabolcs.IsometricAiming
{
    public class IsometricAiming : MonoBehaviour
    {
        #region Datamembers

        #region Editor Settings

        [SerializeField] private LayerMask groundMask;
        [SerializeField] private LayerMask enemyMask;
        [SerializeField] private GameObject projectilePrefab;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private float projectileSpeed = 10f;
        [SerializeField] private float shootRate = 0.2f;

        #endregion

        #region Private Fields


        private Camera mainCamera;
        private float nextShootTime = 0f;

        #endregion

        #endregion

        #region Methods

        #region Unity Callbacks

        private void Start()
        {
            mainCamera = Camera.main;
            // StartCoroutine(SpawnEnemies()); // Commented out as respawn is to be removed
        }

        private void Update()
        {
            // ��Ǩ�ͺ���������ԡ���躹 UI �������
            if (EventSystem.current.IsPointerOverGameObject())
                return; // ���ӧҹ�ҡ��������躹 UI

            if (Input.GetMouseButton(0) && Time.time >= nextShootTime)
            {
                Shoot();
                nextShootTime = Time.time + shootRate;
            }
        }

        #endregion

        private void Shoot()
        {
            // ��Ǩ�ͺ���������ԡ���躹 UI �������
            if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("Click detected on UI");
                return; // ���ӧҹ�ҡ��������躹 UI
            }

            var (hitEnemy, hitPosition) = GetMouseClickTarget();

            if (hitEnemy)
            {
                Debug.Log("Enemy hit!");
            }
            else
            {
                Debug.Log("Shooting at ground or empty space");
            }

            if (hitPosition != Vector3.zero)
            {
                var projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                var direction = (hitPosition - transform.position).normalized;
                var rb = projectile.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = direction * projectileSpeed;
                }
                Destroy(projectile, 5f);
            }
        }


        private (bool hitEnemy, Vector3 position) GetMouseClickTarget()
        {
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var enemyHitInfo, Mathf.Infinity, enemyMask))
            {
                return (hitEnemy: true, position: enemyHitInfo.point);
            }

            if (Physics.Raycast(ray, out var groundHitInfo, Mathf.Infinity, groundMask))
            {
                return (hitEnemy: false, position: groundHitInfo.point);
            }

            return (hitEnemy: false, position: Vector3.zero);
        }

        // Removed the SpawnEnemies coroutine
        // Removed the SpawnEnemy method

        #endregion
    }
}

