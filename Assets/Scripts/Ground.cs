using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / transform.localScale.x;
        _meshRenderer.material.mainTextureOffset += Vector2.right * (speed * Time.deltaTime);
    }
}