using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TreasureHuntShowLegendaryUIMessage : NetworkMessage
	{
		public const uint Id = 6498;

		public uint[] availableLegendaryIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6498;
			}
		}

		public TreasureHuntShowLegendaryUIMessage()
		{
		}

		public TreasureHuntShowLegendaryUIMessage(uint[] availableLegendaryIds)
		{
			this.availableLegendaryIds = availableLegendaryIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.availableLegendaryIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.availableLegendaryIds[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.availableLegendaryIds.Length));
			uint[] numArray = this.availableLegendaryIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}