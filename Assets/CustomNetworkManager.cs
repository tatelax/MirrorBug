using Mirror;
using UnityEngine;

public class CustomNetworkManager : NetworkManager
{
	public struct TestMessage : NetworkMessage
	{
		public string msg;
	}

	private new void Awake()
	{
		NetworkServer.RegisterHandler<TestMessage>(MsgReceived);
	}

	private void MsgReceived(NetworkConnection arg1, TestMessage arg2)
	{
		Debug.Log($"Msg Received {arg2.msg}");
	}

	public override void OnServerReady(NetworkConnection conn)
	{
		base.OnServerReady(conn);

		TestMessage newMsg = new TestMessage
		{
			msg = "Hello World!"
		};

		NetworkServer.SendToAll(newMsg);
	}
}
