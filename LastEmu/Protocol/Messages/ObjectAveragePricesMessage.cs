using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectAveragePricesMessage : NetworkMessage
	{
		public const uint Id = 6335;

		public uint[] ids;

		public uint[] avgPrices;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6335;
			}
		}

		public ObjectAveragePricesMessage()
		{
		}

		public ObjectAveragePricesMessage(uint[] ids, uint[] avgPrices)
		{
			this.ids = ids;
			this.avgPrices = avgPrices;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.ids = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.ids[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.avgPrices = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.avgPrices[j] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.ids.Length));
			uint[] numArray = this.ids;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.avgPrices.Length));
			uint[] numArray1 = this.avgPrices;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarInt((int)numArray1[j]);
			}
		}
	}
}