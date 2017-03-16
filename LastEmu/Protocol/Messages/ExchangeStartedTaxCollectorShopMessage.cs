using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartedTaxCollectorShopMessage : NetworkMessage
	{
		public const uint Id = 6664;

		public ObjectItem[] objects;

		public uint kamas;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6664;
			}
		}

		public ExchangeStartedTaxCollectorShopMessage()
		{
		}

		public ExchangeStartedTaxCollectorShopMessage(ObjectItem[] objects, uint kamas)
		{
			this.objects = objects;
			this.kamas = kamas;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.objects = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objects[i] = new ObjectItem();
				this.objects[i].Deserialize(reader);
			}
			this.kamas = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.objects.Length));
			ObjectItem[] objectItemArray = this.objects;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
			writer.WriteVarInt((int)this.kamas);
		}
	}
}