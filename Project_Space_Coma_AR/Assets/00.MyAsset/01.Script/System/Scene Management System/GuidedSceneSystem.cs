using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuidedSceneSystem : SceneObject<GuidedSceneSystem>
{
    [SerializeField] Image fadeImage;
    [SerializeField, Range(0.001f, 1)] float fadeSpeed;

    [SerializeField] string nextSceneName;

    void Start()
    {
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1);
        StartCoroutine(GuideSystem());
    }

    IEnumerator GuideSystem()
    {
        while (true)
        {            
            yield return new WaitUntil(() => GameManager.Instance.CurrentScene == GameManager.Scenes.GuidedScene);

            yield return StartCoroutine(GameManager.FadeOut(fadeImage, fadeSpeed));
            yield return new WaitForSeconds(2.0f);
            yield return StartCoroutine(GameManager.FadeIn(fadeImage, fadeSpeed));

            GameManager.ChangeScene(nextSceneName);
        }
    }
}
