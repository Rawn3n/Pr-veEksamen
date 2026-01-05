using UnityEngine;
using Unity.Netcode;
using UnityEngine.InputSystem;
using Unity.Cinemachine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private Camera _camera;

    public override void OnNetworkSpawn() // Start funktion i Netcode
    {
        if (!IsOwner)
        {
            _camera.enabled = false;
            GetComponentInChildren<CinemachineBrain>().enabled = false;
        }
    }

    void Update()
    {
        if (!IsOwner) return;

        // player input here
    }
}

