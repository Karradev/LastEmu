using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceFactsErrorMessage : NetworkMessage
	{
		public const uint Id = 6423;

		public uint allianceId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6423;
			}
		}

		public AllianceFactsErrorMessage()
		{
		}

		public AllianceFactsErrorMessage(uint allianceId)
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