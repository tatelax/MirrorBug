Open SampleScene, press Play, then start Host Mode.

[See CustomNetworkManager.cs](https://github.com/tatelax/MirrorBug/blob/master/Assets/CustomNetworkManager.cs)

I've created a NetworkManager which overrides OnServerReady (I noticed it doesn't matter too much which function I override). In that function, I construct a message and send it using NetworkServer.SendToAll();

MsgReceived never happens, however this is not my main issue. My problem is that on the **SECOND** time of Starting and Stopping Host Mode, the Client is not in it's Ready state. You can see this by observing the NetworkHUD.

**NOTE:** If you remove the BasicAuthenticator component from the NetworkManager GameObject in SampleScene, normal behavior is resumed... I have tested with other authenticators and the result is the same so I don't believe BasicAuthenticator is the problem, it's just the one I'm using in this example.
