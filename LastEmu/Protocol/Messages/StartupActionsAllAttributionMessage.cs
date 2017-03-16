using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StartupActionsAllAttributionMessage : NetworkMessage
	{
		public const uint Id = 6537;

		public double characterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6537;
			}
		}

		public StartupActionsAllAttributionMessage()
		{
		}

		public StartupActionsAllAttributionMessage(double characterId)
		{
			this.characterId = characterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.characterId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.characterId);
		}
	}
}