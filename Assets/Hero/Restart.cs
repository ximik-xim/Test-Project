using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : ReactionTrigger
{
    [SerializeField] private SceneAsset _scene;

    public override void ReactionInvoke(Collider collider)
    {
        SceneManager.LoadScene(_scene.name);
    }
}
