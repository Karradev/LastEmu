using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
	{
		public const uint Id = 6470;

		public uint[] ids;

		public uint[] qtys;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6470;
			}
		}

		public ExchangeObjectTransfertListWithQuantityToInvMessage()
		{
		}

		public ExchangeObjectTransfertListWithQuantityToInvMessage(uint[] ids, uint[] qtys)
		{
			this.ids = ids;
			this.qtys = qtys;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.ids = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.ids[i] = reader.ReadVarUhInt();
			}
			num = reader.ReadUShort();
			this.qtys = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.qtys[j] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.ids.Length));
			uint[] numArray = this.ids;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.qtys.Length));
			uint[] numArray1 = this.qtys;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarInt((int)numArray1[j]);
			}
		}
	}
}