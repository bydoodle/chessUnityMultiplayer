using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetcodePawn : NetworkBehaviour
{
    public bool startAsHost;

    private void Start()
    {
        if (startAsHost) NetworkManager.Singleton.StartHost();
        else NetworkManager.Singleton.StartClient();
    }
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        if (!IsHost) return;

        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnectedCallback;
    }

    private void OnClientConnectedCallback(ulong id)
    {
        Debug.Log("Client connected with ID: {id}");
    }
}
