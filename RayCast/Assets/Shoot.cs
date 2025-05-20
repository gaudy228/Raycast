using DG.Tweening;
using UnityEngine;
public class Shoot : MonoBehaviour
{
    [SerializeField] private Material _material;
    private Camera _camera;
    private RaycastHit _hit;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _pointShoot;
    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        if (Physics.Raycast(ray, out _hit))
        {
            GameObject cube = _hit.collider.gameObject;
            if (cube != null)
            {
                cube.GetComponent<CubeMaterial>().Select();
            }
            if (Input.GetMouseButtonDown(0) && cube != null)
            {
                GameObject bul = Instantiate(_bullet, _pointShoot.position, Quaternion.identity);
                bul.transform.DOMove(_hit.point, 1);
                Destroy(bul, 10f);
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 1000;
        Gizmos.DrawRay(transform.position, direction);
    }
}
