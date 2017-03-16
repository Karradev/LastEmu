using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeObjectTransfertListFromInvMessage : NetworkMessage
	{
		public const uint Id = 6183;

		public uint[] ids;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6183;
			}
		}

		public ExchangeObjectTransfertListFromInvMessage()
		{
		}

		public ExchangeObjectTransfertListFromInvMessage(uint[] ids)
		{
			this.ids = ids;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.ids = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.ids[i] = reader.ReadVarUhInt();
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
		}
	}
}