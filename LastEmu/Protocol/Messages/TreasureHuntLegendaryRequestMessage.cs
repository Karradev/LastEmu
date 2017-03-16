using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntLegendaryRequestMessage : NetworkMessage
	{
		public const uint Id = 6499;

		public uint legendaryId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6499;
			}
		}

		public TreasureHuntLegendaryRequestMessage()
		{
		}

		public TreasureHuntLegendaryRequestMessage(uint legendaryId)
		{
			this.legendaryId = legendaryId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.legendaryId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.legendaryId);
		}
	}
}