using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayArenaUnregisterMessage : NetworkMessage
	{
		public const uint Id = 6282;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6282;
			}
		}

		public GameRolePlayArenaUnregisterMessage()
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