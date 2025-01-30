using UnityEngine;

public class ReplaceMeshCollider : MonoBehaviour
{
    void Start()
    {
        // Tìm tất cả GameObject trong cảnh
        MeshCollider[] meshColliders = FindObjectsOfType<MeshCollider>();

        foreach (MeshCollider meshCollider in meshColliders)
        {
            GameObject obj = meshCollider.gameObject;

            // Lưu thông tin Mesh trước khi xóa
            Mesh mesh = meshCollider.sharedMesh;

            // Xóa MeshCollider
            Destroy(meshCollider);

            // Thêm BoxCollider
            BoxCollider boxCollider = obj.AddComponent<BoxCollider>();

            // Ước lượng BoxCollider dựa trên Bounds của Mesh
            if (mesh != null)
            {
                boxCollider.center = mesh.bounds.center;
                boxCollider.size = mesh.bounds.size;
            }

            Debug.Log($"Replaced MeshCollider with BoxCollider on {obj.name}");
        }
    }
}
