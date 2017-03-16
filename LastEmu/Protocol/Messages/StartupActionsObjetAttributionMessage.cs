using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StartupActionsObjetAttributionMessage : NetworkMessage
	{
		public const uint Id = 1303;

		public int actionId;

		public double characterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1303;
			}
		}

		public StartupActionsObjetAttributionMessage()
		{
		}

		public StartupActionsObjetAttributionMessage(int actionId, double characterId)
		{
			this.actionId = actionId;
			this.characterId = characterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.actionId = reader.ReadInt();
			this.characterId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.actionId);
			writer.WriteVarLong(this.characterId);
		}
	}
}