using System.Collections;
using UnityEngine;

public class Elf : EnemyParent
{

    [Header("Behaviour")]
    [SerializeField] private float invisInterval;
    [SerializeField] private float invisTime;
    [SerializeField] private MeshRenderer renderer;

    private void Start() => StartCoroutine(ToggleVisibility());

    private void Update() => Patrol();

    private IEnumerator ToggleVisibility()
    {
        yield return new WaitForSeconds(invisInterval);
        renderer.enabled = false;

        yield return new WaitForSeconds(invisTime);
        renderer.enabled = true;

        StartCoroutine(ToggleVisibility());
    }
}
