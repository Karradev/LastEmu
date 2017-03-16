using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceKickRequestMessage : NetworkMessage
	{
		public const uint Id = 6400;

		public uint kickedId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6400;
			}
		}

		public AllianceKickRequestMessage()
		{
		}

		public AllianceKickRequestMessage(uint kickedId)
		{
			this.kickedId = kickedId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.kickedId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.kickedId);
		}
	}
}