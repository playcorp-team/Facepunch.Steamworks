namespace Steamworks.Data {
	
	public struct P2PSessionState {
		//Copied from Internal struct
		public byte ConnectionActive; // m_bConnectionActive uint8
		public byte Connecting; // m_bConnecting uint8
		public P2PSessionError P2PSessionError; // m_eP2PSessionError uint8
		public bool UsingRelay; // m_bUsingRelay uint8
		public int BytesQueuedForSend; // m_nBytesQueuedForSend int32
		public int PacketsQueuedForSend; // m_nPacketsQueuedForSend int32
		public uint RemoteIP; // m_nRemoteIP uint32
		public ushort RemotePort; // m_nRemotePort uint16

		internal P2PSessionState(P2PSessionState_t internalState) {
			ConnectionActive = internalState.ConnectionActive;
			Connecting = internalState.Connecting;
			P2PSessionError = (P2PSessionError)internalState.P2PSessionError;
			UsingRelay = internalState.UsingRelay == 1;
			BytesQueuedForSend = internalState.BytesQueuedForSend;
			PacketsQueuedForSend = internalState.PacketsQueuedForSend;
			RemoteIP = internalState.RemoteIP;
			RemotePort = internalState.RemotePort;
		}

	}
}
