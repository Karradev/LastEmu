using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
	{
		public const uint Id = 5765;

		public uint[] typeDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5765;
			}
		}

		public ExchangeTypesExchangerDescriptionForUserMessage()
		{
		}

		public ExchangeTypesExchangerDescriptionForUserMessage(uint[] typeDescription)
		{
			this.typeDescription = typeDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.typeDescription = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.typeDescription[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.typeDescription.Length));
			uint[] numArray = this.typeDescription;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}