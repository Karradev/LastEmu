using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceFactsRequestMessage : NetworkMessage
	{
		public const uint Id = 6409;

		public uint allianceId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6409;
			}
		}

		public AllianceFactsRequestMessage()
		{
		}

		public AllianceFactsRequestMessage(uint allianceId)
		{
			this.allianceId = allianceId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allianceId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.allianceId);
		}
	}
}