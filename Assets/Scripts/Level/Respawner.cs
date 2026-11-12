using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;

    WaitForSeconds respawnWaitTimer;
    WaitForSeconds RespawnWaitTimer
    {
        get
        {
            if (respawnWaitTimer == null)
            {
                respawnWaitTimer = new WaitForSeconds(respawnDelay);
            }

            return respawnWaitTimer;
        }
    }
    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += ItemDestroyed;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= ItemDestroyed;
    }

    void OnDestroy()
    {
        StopAllCoroutines();
    }

    public void ItemDestroyed(GameItem gameItem)
    {
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        yield return RespawnWaitTimer;
        Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
