using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildFightJoinRequestMessage : NetworkMessage
	{
		public const uint Id = 5717;

		public int taxCollectorId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5717;
			}
		}

		public GuildFightJoinRequestMessage()
		{
		}

		public GuildFightJoinRequestMessage(int taxCollectorId)
		{
			this.taxCollectorId = taxCollectorId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.taxCollectorId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.taxCollectorId);
		}
	}
}