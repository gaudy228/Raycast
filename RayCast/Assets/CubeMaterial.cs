using UnityEngine;
public class CubeMaterial : MonoBehaviour
{
    public bool _select;
    [SerializeField] private Material _material;
    [SerializeField] private Material _defalt;
    public void Select()
    {
        gameObject.GetComponent<MeshRenderer>().material = _material;
    }
    private void Update()
    {
        if (!_select)
        {
            gameObject.GetComponent<MeshRenderer>().material = _defalt;
        }
    }
}
