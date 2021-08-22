using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �޽� ���� Ŭ����
/// </summary>
[RequireComponent(typeof(MeshFilter))]
public class ReverseNormal : MonoBehaviour
{
    #region ����

    MeshFilter meshFilter;

    #endregion

    #region ����Ƽ ���� �ֱ�

    void Start() => ReverseMesh();

    #endregion

    #region ������

    /// <summary> �޽� ������ ��� ���� ������ ���� ����� �޽��� ������Ű�� �Լ� </summary>
    void ReverseMesh()
    {
        meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            Mesh mesh = meshFilter.mesh;

            //��� �� ����
            Vector3[] normals = mesh.normals;
            for (int i = 0; i < normals.Length; i++)
                normals[i] = -normals[i];
            mesh.normals = normals;

            //������ ���� ������ �ð���⿡�� �ݽð�������� ����
            int[] triangles = mesh.triangles;
            for (int i = 0; i < mesh.subMeshCount; i++)
            {
                //int[] triangles = mesh.GetTriangles(i);

                for (int j = 0; j < triangles.Length; j += 3)
                {
                    int temp = triangles[j];
                    triangles[j] = triangles[j + 1];
                    triangles[j + 1] = temp;
                }
                mesh.triangles = triangles;
                //mesh.SetTriangles(triangles, i);
            }
        }
    }

    #endregion
}
