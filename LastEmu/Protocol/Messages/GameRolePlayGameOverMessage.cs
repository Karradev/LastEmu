using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayGameOverMessage : NetworkMessage
	{
		public const uint Id = 746;

		public override uint ProtocolId
		{
			get
			{
				return (uint)746;
			}
		}

		public GameRolePlayGameOverMessage()
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