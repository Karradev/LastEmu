using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayFreeSoulRequestMessage : NetworkMessage
	{
		public const uint Id = 745;

		public override uint ProtocolId
		{
			get
			{
				return (uint)745;
			}
		}

		public GameRolePlayFreeSoulRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}