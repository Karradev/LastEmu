using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildFightLeaveRequestMessage : NetworkMessage
	{
		public const uint Id = 5715;

		public int taxCollectorId;

		public double characterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5715;
			}
		}

		public GuildFightLeaveRequestMessage()
		{
		}

		public GuildFightLeaveRequestMessage(int taxCollectorId, double characterId)
		{
			this.taxCollectorId = taxCollectorId;
			this.characterId = characterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.taxCollectorId = reader.ReadInt();
			this.characterId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.taxCollectorId);
			writer.WriteVarLong(this.characterId);
		}
	}
}