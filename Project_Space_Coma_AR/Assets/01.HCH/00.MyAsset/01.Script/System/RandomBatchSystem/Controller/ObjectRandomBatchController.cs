using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectRandomBatchController : MonoBehaviour
{
    #region ����

    protected WaitForSecondsRealtime realtime;
    [SerializeField] protected float minGenerateCooltime, maxGenerateCooltime;

    protected int generateCount = 0;

    #endregion

    #region ������

    /// <summary> ������Ʈ ������ ��ƾ�� �����ϴ� �Լ� </summary>
    /// <param name="minGenerateCooltime"> �ּ� ���� ��Ÿ�� </param>
    /// <param name="maxGenerateCooltime"> �ִ� ���� ��Ÿ�� </param>
    /// <param name="maxCount"> Scene ��ġ�� ���� �ִ� ���� ���� </param>
    /// <returns> </returns>
    protected virtual IEnumerator GenerateObject(float minGenerateCooltime, float maxGenerateCooltime, int maxCount)
    {
        while (true)
        {
            yield return new WaitUntil(() => generateCount < maxCount);
            realtime = new WaitForSecondsRealtime(Random.Range(minGenerateCooltime, maxGenerateCooltime));
            generateCount++;
            yield return realtime;

            SettingObject();
        }
    }

    protected abstract void SettingObject();

    protected virtual Vector3 ObjectRandomPosition()
    {
        Vector3 tempVec = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        return tempVec * Random.Range(0, BackgroundSystem.Instance.BackgroundRadius - 1);
    }

    protected abstract Vector3 ObjectRandomScale();

    protected abstract Color DustRandomColor();

    #endregion
}
