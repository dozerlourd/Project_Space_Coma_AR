using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRandomBatchSystem : ObjectRandomBatchController
{
    #region ����

    public static ObstacleRandomBatchSystem Instance;

    [SerializeField] GameObject[] Obstacles;

    [SerializeField] int obstacleMaxCount = 20;

    [SerializeField] float minScalar, maxScalar;

    #endregion

    #region ����Ƽ �����ֱ�

    private void Awake()
    {
        if (!Instance) Instance = this;
        else Destroy(gameObject);
    }

    private void Start() => StartCoroutine(GenerateObject(minGenerateCooltime, maxGenerateCooltime, obstacleMaxCount));

    #endregion

    #region ������

    protected override void SettingObject()
    {
        GameObject generateObject = JHS.PoolManager.Instance.PopObject(Obstacles[Random.Range(0, Obstacles.Length)]);

        generateObject.transform.position = ObjectRandomPosition();
        generateObject.transform.localScale = ObjectRandomScale();
        generateObject.GetComponent<Renderer>().material.color = DustRandomColor();
    }

    protected override Vector3 ObjectRandomScale()
    {
        float temp = Random.Range(minScalar, maxScalar);
        return new Vector3(temp, temp, temp);
    }

    protected override Color DustRandomColor()
    {
        return Color.white;
    }

    #endregion
}
